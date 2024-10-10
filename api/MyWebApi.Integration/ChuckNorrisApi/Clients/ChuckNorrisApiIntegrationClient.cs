using MyWebApi.Integration.ChuckNorrisApi.Models.Response;
using System.Text.Json;

namespace MyWebApi.Integration.ChuckNorrisApi.Clients
{
    public class ChuckNorrisApiIntegrationClient : IChuckNorrisApiIntegrationClient
    {
        private readonly HttpClient _httpClient;

        public ChuckNorrisApiIntegrationClient(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<JokeResponse> GetRandomJoke()
        {
            var randomJokeUrl = "jokes/random";

            var response = await _httpClient.GetAsync(randomJokeUrl);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var joke = JsonSerializer.Deserialize<JokeResponse>(jsonResponse);

            return joke;
        }
    }
}
