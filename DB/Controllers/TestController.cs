using Microsoft.AspNetCore.Mvc;

namespace DB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new List<string> { "data1", "data2", "data3", "data4" };
        }
    }
}
