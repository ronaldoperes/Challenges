using Microsoft.AspNetCore.Mvc;
using WebAppCodes.Etc;

namespace WebAppCodes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var s = ExLinq.BasicAggregate();
            return Ok(s);
        }

        [HttpGet("str")]        
        public IActionResult Index2(string str)
        {
            return Ok($"Now there is something different {str}");
        }

    }
}
