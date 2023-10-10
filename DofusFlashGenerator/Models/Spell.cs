using System.Text.Json.Serialization;

namespace DofusFlashGenerator.Models
{
    public sealed class SpellIcon
    {
        public const int INDEX_REMASTERED = 0;
        public const int INDEX_CONTRAST = 1;
        public const int INDEX_CLASSIC_ANGELIC = 2;
        public const int INDEX_CLASSIC_DIABOLIC = 3;

        [JsonPropertyName("up")]
        public int UpGfxId { get; init; }

        [JsonPropertyName("pc")]
        public List<int> PrintColors { get; init; }

        [JsonPropertyName("b")]
        public int BackGfxId { get; init; }

        [JsonPropertyName("fc")]
        public List<int> FrameColors { get; init; }

        [JsonPropertyName("bc")]
        public List<int> BackgroundColors { get; init; }

        public SpellIcon()
        {
            PrintColors = new();
            FrameColors = new();
            BackgroundColors = new();
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

        public Spell()
        {
            Name = string.Empty;
            Icon = new();
        }
    }
}
