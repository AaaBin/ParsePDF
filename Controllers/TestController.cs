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
    }
}