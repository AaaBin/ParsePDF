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


        [HttpPost(nameof(PostABC))]
        public IActionResult PostABCD()
        {
            return Ok("ABCD");
        }
    }
}