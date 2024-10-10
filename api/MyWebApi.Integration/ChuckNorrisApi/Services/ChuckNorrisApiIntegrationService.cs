using MyWebApi.Integration.ChuckNorrisApi.Clients;
using MyWebApi.Integration.ChuckNorrisApi.Models.Dto;

namespace MyWebApi.Integration.ChuckNorrisApi.Services
{
    public class ChuckNorrisApiIntegrationService : IChuckNorrisApiIntegrationService
    {
        private readonly IChuckNorrisApiIntegrationClient _client;

        public ChuckNorrisApiIntegrationService(IChuckNorrisApiIntegrationClient client)
        {
            _client = client;
        }

        public async Task<JokeDto> GetRandomJoke()
        {
            var joke = await _client.GetRandomJoke();

            return new() 
            {
                Value = joke.Value,
                IconUrl = joke.IconUrl,
                Url = joke.Url
            };
        }
    }
}
