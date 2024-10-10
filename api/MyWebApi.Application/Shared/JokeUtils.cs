using MyWebApi.Application.Services.Joke.Responses;
using MyWebApi.Integration.ChuckNorrisApi.Models.Dto;

namespace MyWebApi.Application.Shared
{
    internal static class JokeUtils
    {
        public static JokeModel ToModel(this JokeDto jokeDto)
        {
            return new JokeModel
            {
                IconUrl = jokeDto.IconUrl,
                Url = jokeDto.Url,
                Value = jokeDto.Value
            };
        }
    }
}
