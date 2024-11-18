namespace DofusFlashGenerator;

public static class Constant
{
    //Client
    public static readonly string Client_FolderPath = Path.Join(Application.StartupPath, "client");
    public static readonly string Client_LoaderFilePath = Path.Join(Client_FolderPath, "loader.swf");
    public static readonly string Client_SpelliconFilePath = Path.Join(Client_FolderPath, "spellicon.swf");
    public static readonly string Client_ClipFolderPath = Path.Join(Client_FolderPath, "clips");
    public static readonly string Client_GfxFolderPath = Path.Join(Client_ClipFolderPath, "gfx");
    public static readonly string Client_DataFolderPath = Path.Join(Client_FolderPath, "data");
    public static readonly string Client_MapsFolderPath = Path.Join(Client_DataFolderPath, "maps");
    public static readonly string Client_SpellsFolderPath = Path.Join(Client_ClipFolderPath, "spells");
    public static readonly string Client_SpellsIconsFolderPath = Path.Join(Client_SpellsFolderPath, "icons");
    public static readonly string Client_SpellsIconsBackFolderPath = Path.Join(Client_SpellsIconsFolderPath, "back");
    public static readonly string Client_SpellsIconsUpFolderPath = Path.Join(Client_SpellsIconsFolderPath, "up");

    //Data
    public static readonly string MapsKeyDataFilePath = Path.Join(Application.StartupPath, "maps.json");
    public static readonly string SpellsDataFilePath = Path.Join(Application.StartupPath, "spells.json");

    //Output
    public static readonly string Output_FolderPath = Path.Join(Application.StartupPath, "output");
    public static readonly string Output_MapsFolderPath = Path.Join(Output_FolderPath, "maps");
    public static readonly string Output_SpelliconsFolderPath = Path.Join(Output_FolderPath, "spellicons");
}
