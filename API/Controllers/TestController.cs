using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace restApi.Controllers
{
    [Route("api/Tests")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("GetIndex")]
        public IActionResult GetIndex()
        {
            return Ok("Pozvan endpoint: GetIndex()");
        }
    }
}
