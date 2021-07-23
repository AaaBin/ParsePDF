namespace ParsePDF.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        public async Task<IActionResult> SayHELLO()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return Ok("HELLO~~~");
        }


        [HttpGet(nameof(SayGoodBye))]
        public async Task<IActionResult> SayGoodBye()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return Ok($"GoodBye~~~");
        }

        [HttpGet(nameof(GetRandomNum))]
        public int GetRandomNum()
        {
            return new Random().Next();
        }

        [HttpGet(nameof(PrintTime))]
        public IActionResult PrintTime()
        {
            return Ok($"{DateTime.Now:yyyy:MM:dd HH:mm:ss}");
        }

        [HttpPost(nameof(PostOneThing))]
        public IActionResult PostOneThing(string name)
        {
            return Ok("OneThing");
        }

        [HttpPost(nameof(PostABCD))]
        public IActionResult PostABCD()
        {
            return Ok("ABCD");
        }

        [HttpGet(nameof(SayEnglish))]
        public IActionResult SayEnglish()
        {
            return Ok("This is a book.");
        }

        [HttpGet(nameof(TEST07))]
        public IActionResult TEST07()
        {
            return Ok("TEST07");
        }
    }
}