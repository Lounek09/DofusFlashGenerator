using DofusFlashGenerator.Models;
using DofusFlashGenerator.Utils;

using System.Diagnostics;
using System.Text.Json;

namespace DofusFlashGenerator.Forms
{
    public sealed partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;

        private int _mapNumber;
        private List<MapKey> _mapKeys;

        private List<Spell> _spells;
        private int _spellBackNumber;
        private int _spellUpNumber;

        public MainForm()
        {
            InitializeComponent();
            _httpClient = new();
            _mapKeys = new();
            _spells = new();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateMapKeysButton.Enabled = !string.IsNullOrEmpty(MapKey.API_URL);
            UpdateMapKeys();
            UpdateSpells();
            UpdateClient();
        }

        private void OpenClientFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Constant.CLIENT_FOLDER_PATH);
        }

        private void UpdateClient()
        {
            _mapNumber = Directory.GetFiles(Constant.CLIENT_MAPS_FOLDER_PATH, "*.swf").Length;
            MapsLabel.Text = $"Maps : {_mapNumber}";

            _spellBackNumber = Directory.GetFiles(Constant.CLIENT_SPELLS_ICONS_BACK_FOLDER_PATH, "*.swf").Length;
            SpellBacksLabel.Text = $"Backs : {_spellBackNumber}";

            _spellUpNumber = Directory.GetFiles(Constant.CLIENT_SPELLS_ICONS_UP_FOLDER_PATH, "*.swf").Length;
            SpellUpsLabel.Text = $"Ups : {_spellUpNumber}";
        }

        private async void UpdateMapKeysButton_Click(object sender, EventArgs e)
        {
            EnabledMainButtons(false);

            InformationLabel.Text = "Download of map keys...";

            string json;
            try
            {
                json = await _httpClient.GetStringAsync(MapKey.API_URL);
            }
            catch (HttpRequestException)
            {
                InformationLabel.Text = $"Error while downloading the json from {MapKey.API_URL}";
                return;
            }

            List<MapKey> mapKeys;
            try
            {
                mapKeys = Json.Load<List<MapKey>>(json);
            }
            catch (JsonException)
            {
                InformationLabel.Text = $"Error while deserializing the json from {MapKey.API_URL}";
                return;
            }

            mapKeys = mapKeys.Where(x => File.Exists($"{Constant.CLIENT_MAPS_FOLDER_PATH}/{x.ToSwfFileName()}")).OrderBy(x => x.Id).ToList();

            if (mapKeys.SequenceEqual(_mapKeys))
                InformationLabel.Text = "No new key detected";
            else
            {
                File.WriteAllText(Constant.MAPSKEYS_FILE_PATH, JsonSerializer.Serialize(mapKeys));
                InformationLabel.Text = "Map keys downloaded successfully";
            }

            UpdateMapKeys();
            EnabledMainButtons(true);
        }

        private void UpdateMapKeys()
        {
            if (!File.Exists(Constant.MAPSKEYS_FILE_PATH))
                return;

            _mapKeys = Json.LoadFromFile<List<MapKey>>(Constant.MAPSKEYS_FILE_PATH);
            MapKeysLabel.Text = $"Keys : {_mapKeys.Count}";
        }

        private void UpdateSpells()
        {
            if (!File.Exists(Constant.SPELLS_FILE_PATH))
                return;

            JsonElement element = Json.LoadFromFile<JsonElement>(Constant.SPELLS_FILE_PATH);
            _spells = Json.Load<List<Spell>>(element.GetProperty("S").GetRawText());
            SpellsLabel.Text = $"Spells : {_spells.Count}";
        }

        private void LaunchMapsButton_Click(object sender, EventArgs e)
        {
            UpdateClient();

            if (_mapNumber == 0)
            {
                InformationLabel.Text = $"There is no maps to work with in {Constant.CLIENT_MAPS_FOLDER_PATH}";
                return;
            }

            if (_mapKeys.Count == 0)
            {
                InformationLabel.Text = $"There is no map keys to work with";
                return;
            }

            EnabledMainButtons(false);
            MapFlashForm mapFlashForm = new(this, _mapKeys) { Owner = this };
            mapFlashForm.Show();
        }

        private void LaunchSpellsButton_Click(object sender, EventArgs e)
        {
            UpdateClient();

            if (_spellBackNumber == 0)
            {
                InformationLabel.Text = $"There is no spell back icons to work with in {Constant.CLIENT_SPELLS_ICONS_BACK_FOLDER_PATH}";
                return;
            }

            if (_spellUpNumber == 0)
            {
                InformationLabel.Text = $"There is no spell up icons to work with in {Constant.CLIENT_SPELLS_ICONS_UP_FOLDER_PATH}";
                return;
            }

            if (_spells.Count == 0)
            {
                InformationLabel.Text = $"There is no spells to work with";
                return;
            }

            EnabledMainButtons(false);
            SpellFlashForm spellFlashForm = new(this, _spells) { Owner = this };
            spellFlashForm.Show();
        }

        private void OpenOutputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Constant.OUTPUT_FOLDER_PATH);
        }

        public void EnabledMainButtons(bool enable)
        {
            OpenClientFolderButton.Enabled = enable;
            UpdateMapKeysButton.Enabled = enable;
            LaunchMapButton.Enabled = enable && _mapKeys.Count > 0;
            LaunchSpellsButton.Enabled = enable;
        }
    }
}
