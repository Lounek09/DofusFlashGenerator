using DofusFlashGenerator.Models;
using DofusFlashGenerator.Properties;

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
        LoadMapKeys();
        LoadSpells();
        UpdateClient();

        EnabledMainButtons(true);
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
        Process.Start("explorer.exe", Constant.Client_FolderPath);
    }

    private void UpdateClient()
    {
        _mapNumber = Directory.GetFiles(Constant.Client_MapsFolderPath, "*.swf").Length;
        MapsLabel.Text = $"Maps : {_mapNumber}";

        _spellBackNumber = Directory.GetFiles(Constant.Client_SpellsIconsBackFolderPath, "*.swf").Length;
        SpellBacksLabel.Text = $"Backs : {_spellBackNumber}";

        _spellUpNumber = Directory.GetFiles(Constant.Client_SpellsIconsUpFolderPath, "*.swf").Length;
        SpellUpsLabel.Text = $"Ups : {_spellUpNumber}";
    }

    private async void DownloadMapKeysButton_Click(object sender, EventArgs e)
    {
        EnabledMainButtons(false);

        InformationLabel.Text = "Download of map keys...";

        string json;
        try
        {
            json = await _httpClient.GetStringAsync(Settings.Default.MapApiUrl);
        }
        catch
        {
            InformationLabel.Text = $"Error while downloading the json from {Settings.Default.MapApiUrl}";

            EnabledMainButtons(true);
            return;
        }

        IEnumerable<MapKey> mapKeys;
        try
        {
            mapKeys = JsonSerializer.Deserialize<IEnumerable<MapKey>>(json) ?? [];
        }
        catch (JsonException)
        {
            InformationLabel.Text = $"Error while deserializing the json from {Settings.Default.MapApiUrl}";
            return;
        }

        mapKeys = mapKeys.Where(x => File.Exists($"{Constant.Client_MapsFolderPath}/{x.GetSwfFileName()}"))
            .OrderBy(x => x.Id);

        if (mapKeys.SequenceEqual(_mapKeys))
        {
            InformationLabel.Text = "No new key detected";
        }
        else
        {
            File.WriteAllText(Constant.MapsKeyDataFilePath, JsonSerializer.Serialize(mapKeys));
            InformationLabel.Text = "Map keys downloaded successfully";

            LoadMapKeys();
        }

        EnabledMainButtons(true);
    }

    private void MapApiUrlTextbox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            ChangeMapApiUrlButton_Click(sender, e);
        }
    }

    private void ChangeMapApiUrlButton_Click(object sender, EventArgs e)
    {
        if (MapApiUrlTextbox.Visible)
        {
            if (!Settings.Default.MapApiUrl.Equals(MapApiUrlTextbox.Text))
            {
                Settings.Default.MapApiUrl = MapApiUrlTextbox.Text;
                Settings.Default.Save();

                InformationLabel.Text = "Map API URL updated successfully";
            }

            EnabledMainButtons(true);
            MapApiUrlTextbox.Visible = false;
        }
        else
        {
            MapApiUrlTextbox.Text = Settings.Default.MapApiUrl;

            MapApiUrlTextbox.Visible = true;
        }
    }

    private void LoadMapKeys()
    {
        if (!File.Exists(Constant.MapsKeyDataFilePath))
        {
            return;
        }

        var json = File.ReadAllText(Constant.MapsKeyDataFilePath);

        _mapKeys = JsonSerializer.Deserialize<List<MapKey>>(json) ?? [];
        MapKeysLabel.Text = $"Keys : {_mapKeys.Count}";
    }

    private void LoadSpells()
    {
        if (!File.Exists(Constant.SpellsDataFilePath))
        {
            return;
        }

        var json = File.ReadAllText(Constant.SpellsDataFilePath);

        var element = JsonSerializer.Deserialize<JsonElement>(json);
        _spells = JsonSerializer.Deserialize<List<Spell>>(element.GetProperty("S").GetRawText()) ?? [];

        SpellsLabel.Text = $"Spells : {_spells.Count}";
    }

    private void LaunchMapsButton_Click(object sender, EventArgs e)
    {
        UpdateClient();

        if (_mapNumber == 0)
        {
            InformationLabel.Text = $"There is no maps to work with in {Constant.Client_MapsFolderPath}";
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
            InformationLabel.Text = $"There is no spell back icons to work with in {Constant.Client_SpellsIconsBackFolderPath}";
            return;
        }

        if (_spellUpNumber == 0)
        {
            InformationLabel.Text = $"There is no spell up icons to work with in {Constant.Client_SpellsIconsUpFolderPath}";
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

    private void InformationLabel_TextChanged(object sender, EventArgs e)
    {
        _informationTimer.Stop();
        _informationTimer.Start();
    }

    private void OpenOutputFolderButton_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", Constant.Output_FolderPath);
    }

    public void EnabledMainButtons(bool enable)
    {
        OpenClientFolderButton.Enabled = enable;
        DownloadMapKeysButton.Enabled = enable && !string.IsNullOrEmpty(Settings.Default.MapApiUrl);
        ChangeMapApiUrlButton.Enabled = enable;
        MapApiUrlTextbox.Visible = false;
        LaunchMapButton.Enabled = enable && _mapKeys.Count > 0;
        LaunchSpellsButton.Enabled = enable && _spells.Count > 0;
    }
}
