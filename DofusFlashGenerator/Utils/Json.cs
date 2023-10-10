using System.Text.Json.Serialization;
using System.Text.Json;

namespace DofusFlashGenerator.Utils
{
    public static class Json
    {
        private static readonly JsonSerializerOptions _options = new()
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        public static T Load<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, _options)!;
        }

        public static T LoadFromFile<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);

            return Load<T>(json);
        }
    }
}
