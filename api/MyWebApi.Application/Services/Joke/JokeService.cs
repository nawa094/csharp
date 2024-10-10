using MyWebApi.Application.Services.Joke.Responses;
using MyWebApi.Application.Shared;
using MyWebApi.Integration.ChuckNorrisApi.Services;

namespace MyWebApi.Application.Services.Joke
{
    public class JokeService : IJokeService
    {
        private readonly IChuckNorrisApiIntegrationService _chuckNorrisApiIntegrationService;

        public JokeService(IChuckNorrisApiIntegrationService chuckNorrisApiIntegrationService)
        {
            _chuckNorrisApiIntegrationService = chuckNorrisApiIntegrationService;
        }

        public async Task<JokeModel> GetRandomJoke()
        {
            var joke = await _chuckNorrisApiIntegrationService.GetRandomJoke();

            return joke.ToModel();
        }
    }
}
