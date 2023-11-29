using System.Text.Json.Serialization;

namespace DofusFlashGenerator.Models;

public sealed class SpellIcon
{
    public const int INDEX_REMASTERED = 0;
    public const int INDEX_CONTRAST = 1;
    public const int INDEX_CLASSIC_ANGELIC = 2;
    public const int INDEX_CLASSIC_DIABOLIC = 3;

    [JsonPropertyName("up")]
    public int UpGfxId { get; init; }

    [JsonPropertyName("pc")]
    public IReadOnlyList<int> PrintColors { get; init; }

    [JsonPropertyName("b")]
    public int BackGfxId { get; init; }

    [JsonPropertyName("fc")]
    public IReadOnlyList<int> FrameColors { get; init; }

    [JsonPropertyName("bc")]
    public IReadOnlyList<int> BackgroundColors { get; init; }

    [JsonConstructor]
    internal SpellIcon()
    {
        PrintColors = [];
        FrameColors = [];
        BackgroundColors = [];
    }
}

public sealed class Spell : IData
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("n")]
    public string Name { get; init; }

    [JsonPropertyName("i")]
    public SpellIcon Icon { get; init; }

    [JsonConstructor]
    internal Spell()
    {
        Name = string.Empty;
        Icon = new();
    }
}
