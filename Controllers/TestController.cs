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
        public async Task<IActionResult> SayGoodBye(string name)
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return Ok($"GoodBye {name}");
        }
    }
}