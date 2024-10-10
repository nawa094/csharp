using MyWebApi.Integration.ChuckNorrisApi.Models.Dto;

namespace MyWebApi.Integration.ChuckNorrisApi.Services
{
    public interface IChuckNorrisApiIntegrationService
    {
        Task<JokeDto> GetRandomJoke();
    }
}
