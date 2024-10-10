
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Application.Services.Joke;

namespace MyWebApi.Controllers.Joke
{
    public class JokeController : MyWebApiControllerBase
    {
        private readonly IJokeService _jokeService;

        public JokeController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }

        [HttpGet("random-joke")]
        public async Task<IActionResult> GetRandomJoke()
        {
            var joke = await _jokeService.GetRandomJoke();
            return Ok(joke);
        }
    }
}
