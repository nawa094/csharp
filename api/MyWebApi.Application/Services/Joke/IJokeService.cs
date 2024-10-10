using MyWebApi.Application.Services.Joke.Responses;

namespace MyWebApi.Application.Services.Joke
{
    public interface IJokeService
    {
        Task<JokeModel> GetRandomJoke();
    }
}
