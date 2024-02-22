using AxShockwaveFlashObjects;

using DofusFlashGenerator.Models;
using DofusFlashGenerator.Properties;
using DofusFlashGenerator.Utils;

using System.Drawing.Imaging;

namespace DofusFlashGenerator.Forms;

public partial class SpellFlashForm : Form, IFlashForm<Spell>
{
    private const int AUTOPLAY_DELAY = 500;

    public IReadOnlyList<Spell> Data { get; init; }
    public IReadOnlyList<IData> GenericData => Data.ToList<IData>();
    public int Index { get; private set; }
    public int LastIndex => Data.Count - 1;
    public bool IsAutoPlay { get; private set; }
    public bool IsAutoScreen { get; private set; }

    private readonly MainForm _owner;

    public SpellFlashForm(MainForm owner, List<Spell> spells)
    {
        InitializeComponent();
        InitializeFlashComponent();

        _owner = owner;
        Data = spells;
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        StyleComboBox.SelectedIndex = 0;
        await Display(0);
    }

    private void FlashForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _owner.EnabledMainButtons(true);
    }

    public async Task Display(int index)
    {
        Index = index;
        var spell = Data[index];

        var backUrl = Path.Join(Constant.CLIENT_SPELLS_ICONS_BACK_FOLDER_PATH, spell.Icon.BackGfxId + ".swf");
        var upUrl = Path.Join(Constant.CLIENT_SPELLS_ICONS_UP_FOLDER_PATH, spell.Icon.UpGfxId + ".swf");
        var backgroundColor = spell.Icon.BackgroundColors[StyleComboBox.SelectedIndex];
        var frameColor = spell.Icon.FrameColors[StyleComboBox.SelectedIndex];
        var printColor = spell.Icon.PrintColors[StyleComboBox.SelectedIndex];

        AxShockwaveFlash.LoadMovie(0, $"{Constant.CLIENT_SPELLICON_FILE_PATH}?b={backUrl}&up={upUrl}&bc={backgroundColor}&fc={frameColor}&pc={printColor}");
        IndexLabel.Text = $"{Index + 1}/{Data.Count}";
        InformationLabel.Text = $"{spell.Name} ({spell.Id})";

        if (IsAutoPlay)
        {
            await Task.Delay(AUTOPLAY_DELAY);

            if (IsAutoScreen)
            {
                Screen();
            }

            if (Index < Data.Count - 1)
            {
                await Display(Index + 1);
            }
            else
            {
                await AutoPlay(!IsAutoPlay);
            }
        }
        else
        {
            MediaButtonsControl.EnableMediaButtons(true);
        }
    }

    public async Task AutoPlay(bool enable)
    {
        if (enable)
        {
            IsAutoPlay = true;

            var dialogResult = MessageBox.Show("Do you want to screen automatically each spell icon ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                IsAutoScreen = true;
                Screen();
            }

            MediaButtonsControl.PlayPauseButton.BackgroundImage = Resources.stop;
            MediaButtonsControl.EnableMediaButtons(false);

            await Display(Index + 1);
        }
        else
        {
            IsAutoPlay = false;
            IsAutoScreen = false;

            MediaButtonsControl.PlayPauseButton.BackgroundImage = Resources.playpause_enabled;
            MediaButtonsControl.EnableMediaButtons(true);
        }
    }

    public void Screen()
    {
        var spell = Data[Index];

        var image = Screenshot.Window(AxShockwaveFlash.Handle);

        var codec = ImageCodecInfo.GetImageEncoders()
            .FirstOrDefault(x => x.FormatID == ImageFormat.Jpeg.Guid)!;

        EncoderParameters parameters = new(1)
        {
            Param = new EncoderParameter[1] { new(Encoder.Quality, 100L) }
        };

        var path = Path.Join(Constant.OUTPUT_SPELLICONS_FOLDER_PATH, spell.Id + ".jpg");
        image.Save(path, codec, parameters);
    }

    private async void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        await Display(Index);
    }
}
