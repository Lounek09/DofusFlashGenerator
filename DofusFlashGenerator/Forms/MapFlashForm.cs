using AxShockwaveFlashObjects;

using DofusFlashGenerator.Models;
using DofusFlashGenerator.Properties;
using DofusFlashGenerator.Utils;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DofusFlashGenerator.Forms;

public partial class MapFlashForm : Form, IFlashForm<MapKey>
{
    private const int INIT_DELAY = 2500;
    private const int AUTOPLAY_DELAY = 500;

    public IReadOnlyList<MapKey> Data { get; init; }
    public IReadOnlyList<IData> GenericData => Data.ToList<IData>();
    public int Index { get; private set; }
    public bool IsAutoPlay { get; private set; }
    public bool IsAutoScreen { get; private set; }

    private readonly MainForm _owner;

    public MapFlashForm(MainForm owner, List<MapKey> mapKeys)
    {
        InitializeComponent();
        InitializeFlashComponent();

        _owner = owner;
        Data = mapKeys;
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        AxShockwaveFlash.LoadMovie(0, Constant.CLIENT_LOADER_FILE_PATH);

        await Task.Delay(INIT_DELAY);

        await Display(0);
    }

    private void FlashForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _owner.EnabledMainButtons(true);
    }

    public async Task Display(int index)
    {
        Index = index;
        var mapKey = Data[index];

        try
        {
            AxShockwaveFlash.CallFunction(mapKey.ToFlashXml());
        }
        catch (InvalidComObjectException)
        {
            Console.WriteLine("FlashForm closed before execution");
            return;
        }

        InformationLabel.Text = $"{Index + 1}/{Data.Count} | Id : {mapKey.Id}";
        if (mapKey.IsCracked())
        {
            InformationLabel.Text += " |";
            CrackedPictureBox.Location = new(InformationLabel.Location.X + InformationLabel.Width + 1, CrackedPictureBox.Location.Y);
            CrackedPictureBox.Visible = true;
        }
        else
        {
            CrackedPictureBox.Visible = false;
        }

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

            MediaButtonsControl.PlayPauseButton.BackgroundImage = Resources.stop;
            MediaButtonsControl.EnableMediaButtons(false);

            var dialogResult = MessageBox.Show("Do you want to screen automatically each map ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Screen();
                IsAutoScreen = true;
            }

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
        var mapKey = Data[Index];

        var image = Screenshot.Window(AxShockwaveFlash.Handle);
        Image cracked = Resources.cracked;
        Image watermark = Resources.watermark;

        using (var graphics = Graphics.FromImage(image))
        {
            graphics.DrawImage(watermark, image.Width - watermark.Width - 30, image.Height - watermark.Height - 30);

            if (mapKey.IsCracked())
            {
                graphics.DrawImage(cracked, 5, 5);
            }
        }

        var codec = ImageCodecInfo.GetImageEncoders()
            .FirstOrDefault(x => x.FormatID == ImageFormat.Jpeg.Guid)!;

        EncoderParameters parameters = new(1)
        {
            Param = new EncoderParameter[1] { new(Encoder.Quality, 100L) }
        };

        var path = Path.Join(Constant.OUTPUT_MAPS_FOLDER_PATH, mapKey.Id + ".jpg");
        image.Save(path, codec, parameters);
    }
}
