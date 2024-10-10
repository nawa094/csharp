using System.Text.Json.Serialization;

namespace MyWebApi.Integration.ChuckNorrisApi.Models.Response
{
    public class JokeResponse
    {
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
