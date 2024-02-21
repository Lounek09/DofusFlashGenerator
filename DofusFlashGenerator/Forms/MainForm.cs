using DofusFlashGenerator.Models;
using DofusFlashGenerator.Utils;

using System.Diagnostics;
using System.Text.Json;
using System.Timers;

namespace DofusFlashGenerator.Forms;

public sealed partial class MainForm : Form
{
    private readonly HttpClient _httpClient;
    private readonly System.Timers.Timer _informationTimer;

    private List<MapKey> _mapKeys;
    private int _mapNumber;

    private List<Spell> _spells;
    private int _spellBackNumber;
    private int _spellUpNumber;

    public MainForm()
    {
        InitializeComponent();

        _httpClient = new();
        _informationTimer = new(TimeSpan.FromSeconds(5));
        _mapKeys = new();
        _spells = new();

        _informationTimer.Elapsed += InformationTimer_Elapsed;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        UpdateMapKeysButton.Enabled = !string.IsNullOrEmpty(MapKey.API_URL);
        LoadMapKeys();
        LoadSpells();
        UpdateClient();
    }

    private void InformationTimer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        InformationLabel.Invoke((MethodInvoker)delegate
        {
            InformationLabel.Text = string.Empty;
        });

        _informationTimer.Stop();
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

        IEnumerable<MapKey> mapKeys;
        try
        {
            mapKeys = JsonSerializer.Deserialize<IEnumerable<MapKey>>(json) ?? [];
        }
        catch (JsonException)
        {
            InformationLabel.Text = $"Error while deserializing the json from {MapKey.API_URL}";
            return;
        }

        mapKeys = mapKeys.Where(x => File.Exists($"{Constant.CLIENT_MAPS_FOLDER_PATH}/{x.GetSwfFileName()}"))
            .OrderBy(x => x.Id);

        if (mapKeys.SequenceEqual(_mapKeys))
        {
            InformationLabel.Text = "No new key detected";
        }
        else
        {
            File.WriteAllText(Constant.MAPSKEYS_FILE_PATH, JsonSerializer.Serialize(mapKeys));
            InformationLabel.Text = "Map keys downloaded successfully";

            LoadMapKeys();
        }

        EnabledMainButtons(true);
    }

    private void LoadMapKeys()
    {
        if (!File.Exists(Constant.MAPSKEYS_FILE_PATH))
        {
            return;
        }

        var json = File.ReadAllText(Constant.MAPSKEYS_FILE_PATH);

        _mapKeys = JsonSerializer.Deserialize<List<MapKey>>(json) ?? [];
        MapKeysLabel.Text = $"Keys : {_mapKeys.Count}";
    }

    private void LoadSpells()
    {
        if (!File.Exists(Constant.SPELLS_FILE_PATH))
        {
            return;
        }

        var json = File.ReadAllText(Constant.SPELLS_FILE_PATH);

        var element = JsonSerializer.Deserialize<JsonElement>(json);
        _spells = JsonSerializer.Deserialize<List<Spell>>(element.GetProperty("S").GetRawText()) ?? [];

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

        var form = new MapFlashForm(this, _mapKeys)
        {
            Owner = this
        };

        form.Show();
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

        var form = new SpellFlashForm(this, _spells)
        {
            Owner = this
        };

        form.Show();
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
