using AxShockwaveFlashObjects;

using DofusFlashGenerator.Models;
using DofusFlashGenerator.Properties;
using DofusFlashGenerator.Utils;

using System.Drawing.Imaging;

namespace DofusFlashGenerator.Forms
{
    public partial class SpellFlashForm : Form, IFlashForm
    {
        private const int AUTOPLAY_DELAY = 500;

        public List<Spell> Data { get; init; }
        public int Index { get; private set; }
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
            Spell spell = Data[index];

            string backUrl = Path.Join(Constant.CLIENT_SPELLS_ICONS_BACK_FOLDER_PATH, spell.Icon.BackGfxId + ".swf");
            string upUrl = Path.Join(Constant.CLIENT_SPELLS_ICONS_UP_FOLDER_PATH, spell.Icon.UpGfxId + ".swf");
            int backgroundColor = spell.Icon.BackgroundColors[StyleComboBox.SelectedIndex];
            int frameColor = spell.Icon.FrameColors[StyleComboBox.SelectedIndex];
            int printColor = spell.Icon.PrintColors[StyleComboBox.SelectedIndex];

            AxShockwaveFlash.LoadMovie(0, $"{Constant.CLIENT_SPELLICON_FILE_PATH}?b={backUrl}&up={upUrl}&bc={backgroundColor}&fc={frameColor}&pc={printColor}");
            IndexLabel.Text = $"{Index + 1}/{Data.Count}";
            InformationLabel.Text = $"{spell.Name} ({spell.Id})";

            if (IsAutoPlay)
            {
                await Task.Delay(AUTOPLAY_DELAY);

                if (IsAutoScreen)
                    Screen();

                if (Index < Data.Count - 1)
                    await Display(Index + 1);
                else
                    await AutoPlay(!IsAutoPlay);
            }
            else
                UpdateMediaButtons(true);
        }

        public async Task AutoPlay(bool enable)
        {
            if (enable)
            {
                IsAutoPlay = true;

                DialogResult dialogResult = MessageBox.Show("Do you want to screen automatically each spell icon ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    IsAutoScreen = true;
                    Screen();
                }

                PlayPauseButton.BackgroundImage = Resources.stop;
                UpdateMediaButtons(false);

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
            Spell spell = Data[Index];

            Image image = Screenshot.Window(AxShockwaveFlash.Handle);

            ImageCodecInfo codec = ImageCodecInfo.GetImageEncoders()
                .FirstOrDefault(x => x.FormatID == ImageFormat.Jpeg.Guid)!;

            EncoderParameters parameters = new(1)
            {
                Param = new EncoderParameter[1] { new(Encoder.Quality, 100L) }
            };

            string path = Path.Join(Constant.OUTPUT_SPELLICONS_FOLDER_PATH, spell.Id + ".jpg");
            image.Save(path, codec, parameters);
        }

        private async void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Display(Index);
        }

        private async void MediaButtons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int lastIndex = Data.Count - 1;

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
            Button button = (Button)sender;
            bool enabled = button.Enabled;

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
            int lastIndex = Data.Count - 1;

            SearchButton.Enabled = enabled;
            FirstButton.Enabled = enabled && Index != 0;
            PreviousButton.Enabled = enabled;
            PlayPauseButton.Enabled = (enabled && Index != lastIndex) || IsAutoPlay;
            NextButton.Enabled = enabled;
            LastButton.Enabled = enabled && Index != lastIndex;
            ScreenButton.Enabled = enabled;
        }
    }
}
