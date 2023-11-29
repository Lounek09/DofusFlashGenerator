using AxShockwaveFlashObjects;

using DofusFlashGenerator.Models;
using DofusFlashGenerator.Properties;
using DofusFlashGenerator.Utils;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DofusFlashGenerator.Forms;

public partial class MapFlashForm : Form, IFlashForm
{
    private const int INIT_DELAY = 2500;
    private const int AUTOPLAY_DELAY = 500;

    public List<MapKey> Data { get; init; }
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
            UpdateMediaButtons(true);
        }
    }

    public async Task AutoPlay(bool enable)
    {
        if (enable)
        {
            IsAutoPlay = true;

            PlayPauseButton.BackgroundImage = Resources.stop;
            UpdateMediaButtons(false);

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

            PlayPauseButton.BackgroundImage = Resources.playpause_enabled;
            UpdateMediaButtons(true);
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

    private async void MediaButtons_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var lastIndex = Data.Count - 1;

        switch (button.Name)
        {
            case "SearchButton":
                SearchForm searchForm = new(this, Data.ToList<IData>()) { Owner = this };
                searchForm.Show();
                break;
            case "FirstButton":
                await Display(0);
                break;
            case "PreviousButton":
                await Display(Index == 0 ? lastIndex : Index - 1);
                break;
            case "PlayPauseButton":
                await AutoPlay(!IsAutoPlay);
                break;
            case "NextButton":
                await Display(Index == lastIndex ? 0 : Index + 1);
                break;
            case "LastButton":
                await Display(lastIndex);
                break;
            case "ScreenButton":
                Screen();
                break;
        }
    }

    private void MediaButtons_EnabledChanged(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var enabled = button.Enabled;

        switch (button.Name)
        {
            case "SearchButton":
                button.BackgroundImage = enabled ? Resources.search_enabled : Resources.search_disabled;
                break;
            case "FirstButton":
                button.BackgroundImage = enabled ? Resources.first_enabled : Resources.first_disabled;
                break;
            case "PreviousButton":
                button.BackgroundImage = enabled ? Resources.previous_enabled : Resources.previous_disabled;
                break;
            case "PlayPauseButton":
                button.BackgroundImage = enabled ? Resources.playpause_enabled : Resources.playpause_disabled;
                break;
            case "NextButton":
                button.BackgroundImage = enabled ? Resources.next_enabled : Resources.next_disabled;
                break;
            case "LastButton":
                button.BackgroundImage = enabled ? Resources.last_enabled : Resources.last_disabled;
                break;
            case "ScreenButton":
                button.BackgroundImage = enabled ? Resources.camera_enabled : Resources.camera_disabled;
                break;
        }
    }

    private void UpdateMediaButtons(bool enabled)
    {
        var lastIndex = Data.Count - 1;

        SearchButton.Enabled = enabled;
        FirstButton.Enabled = enabled && Index != 0;
        PreviousButton.Enabled = enabled;
        PlayPauseButton.Enabled = (enabled && Index != lastIndex) || IsAutoPlay;
        NextButton.Enabled = enabled;
        LastButton.Enabled = enabled && Index != lastIndex;
        ScreenButton.Enabled = enabled;
    }
}
