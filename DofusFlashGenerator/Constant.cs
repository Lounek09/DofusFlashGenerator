namespace DofusFlashGenerator;

public static class Constant
{
    //Client
    public static readonly string CLIENT_FOLDER_PATH = Path.Join(Application.StartupPath, "client");
    public static readonly string CLIENT_LOADER_FILE_PATH = Path.Join(CLIENT_FOLDER_PATH, "loader.swf");
    public static readonly string CLIENT_SPELLICON_FILE_PATH = Path.Join(CLIENT_FOLDER_PATH, "spellicon.swf");
    public static readonly string CLIENT_CLIPS_FOLDER_PATH = Path.Join(CLIENT_FOLDER_PATH, "clips");
    public static readonly string CLIENT_GFX_FOLDER_PATH = Path.Join(CLIENT_CLIPS_FOLDER_PATH, "gfx");
    public static readonly string CLIENT_DATA_FOLDER_PATH = Path.Join(CLIENT_FOLDER_PATH, "data");
    public static readonly string CLIENT_MAPS_FOLDER_PATH = Path.Join(CLIENT_DATA_FOLDER_PATH, "maps");
    public static readonly string CLIENT_SPELLS_FOLDER_PATH = Path.Join(CLIENT_CLIPS_FOLDER_PATH, "spells");
    public static readonly string CLIENT_SPELLS_ICONS_FOLDER_PATH = Path.Join(CLIENT_SPELLS_FOLDER_PATH, "icons");
    public static readonly string CLIENT_SPELLS_ICONS_BACK_FOLDER_PATH = Path.Join(CLIENT_SPELLS_ICONS_FOLDER_PATH, "back");
    public static readonly string CLIENT_SPELLS_ICONS_UP_FOLDER_PATH = Path.Join(CLIENT_SPELLS_ICONS_FOLDER_PATH, "up");

    //Data
    public static readonly string MAPSKEYS_FILE_PATH = Path.Join(Application.StartupPath, "maps.json");
    public static readonly string SPELLS_FILE_PATH = Path.Join(Application.StartupPath, "spells.json");

    //Output
    public static readonly string OUTPUT_FOLDER_PATH = Path.Join(Application.StartupPath, "output");
    public static readonly string OUTPUT_MAPS_FOLDER_PATH = Path.Join(OUTPUT_FOLDER_PATH, "maps");
    public static readonly string OUTPUT_SPELLICONS_FOLDER_PATH = Path.Join(OUTPUT_FOLDER_PATH, "spellicons");
}
