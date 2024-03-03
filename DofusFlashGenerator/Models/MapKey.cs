using System.Text.Json.Serialization;

namespace DofusFlashGenerator.Models;

public sealed class MapKey : IData, IEquatable<MapKey?>
{
    [JsonPropertyName("mapId")]
    public int Id { get; init; }

    [JsonPropertyName("date")]
    public string Date { get; init; }

    [JsonPropertyName("key")]
    public string Key { get; init; }

    [JsonPropertyName("crackedKey")]
    public string CrackedKey { get; init; }

    [JsonConstructor]
    internal MapKey()
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

    public string GetSwfFileName()
    {
        return $"{Id}_{Date}X.swf";
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as MapKey);
    }

    public bool Equals(MapKey? other)
    {
        return other is not null &&
               Id == other.Id &&
               Date == other.Date &&
               Key == other.Key &&
               CrackedKey == other.CrackedKey;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Date, Key, CrackedKey);
    }

    public static bool operator ==(MapKey? left, MapKey? right)
    {
        return EqualityComparer<MapKey>.Default.Equals(left, right);
    }

    public static bool operator !=(MapKey? left, MapKey? right)
    {
        return !(left == right);
    }
}
