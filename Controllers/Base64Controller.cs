using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using ParsePDF.Model;

namespace ParsePDF.Controllers
{

    [ApiController]
    [Route("api/base64")]
    public class Base64Controller : ControllerBase
    {

        [HttpPost("toPDF")]
        public IActionResult DownloadPDFFromBase64String(Base64Request request)
        {
            try
            {
                byte[] convertedByteArr = Convert.FromBase64String(request.Base64String);
                var dataStream = new MemoryStream(convertedByteArr);
                return File(dataStream, "application/octet-stream");
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, $"Exception!: {ex.Message}");
            }

        }

    }
}