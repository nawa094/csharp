using MyWebApi.Integration.ChuckNorrisApi.Models.Response;

namespace MyWebApi.Integration.ChuckNorrisApi.Clients
{
    public interface IChuckNorrisApiIntegrationClient
    {
        Task<JokeResponse> GetRandomJoke();
    }
}
