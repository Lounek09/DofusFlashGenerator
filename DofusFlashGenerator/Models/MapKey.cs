using System.Text.Json.Serialization;

namespace DofusFlashGenerator.Models
{
    public sealed class MapKey : IData
    {
        public const string API_URL = "";

        [JsonPropertyName("mapId")]
        public int Id { get; init; }

        [JsonPropertyName("date")]
        public string Date { get; init; }

        [JsonPropertyName("key")]
        public string Key { get; init; }

        [JsonPropertyName("crackedKey")]
        public string CrackedKey { get; init; }

        public MapKey()
        {
            Date = string.Empty;
            Key = string.Empty;
            CrackedKey = string.Empty;
        }

        public bool IsCracked()
        {
            return string.IsNullOrEmpty(Key);
        }

        public string ToFlashXml()
        {
            return $"""
                    <invoke name="loadMap" returntype="xml">
                        <arguments>
                            <number>{Id}</number>
                            <string>{Date}</string>
                            <string>{(IsCracked() ? CrackedKey : Key)}</string>
                        </arguments>
                    </invoke>
                    """;
        }

        public string ToSwfFileName()
        {
            return $"{Id}_{Date}X.swf";
        }
    }
}
