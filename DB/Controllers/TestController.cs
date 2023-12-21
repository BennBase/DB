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
            var test = Commands.Read.ReadJson("data.json");

            if (test != null)
            {
                foreach (var pair in test)
                {
                    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                }
            }
            else
            {
                Console.WriteLine("Failed to read or parse the JSON file.");
            }


            return new List<string> { "data1", "data2", "data3", "data4" };
        }
    }
}
