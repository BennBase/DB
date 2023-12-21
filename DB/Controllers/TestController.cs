using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Types;

namespace DB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<KeyValuePairModel>> Get()
        {
            var jsonKeyValuePairs = Commands.Read.ReadJson("data.json");
            List<KeyValuePairModel> keyValuePairs = new List<KeyValuePairModel>();

            if (jsonKeyValuePairs != null)
            {
                foreach (var pair in jsonKeyValuePairs)
                {
                    keyValuePairs.Add(new KeyValuePairModel(pair.Key, pair.Value));
                }
                return Ok(keyValuePairs);
            }
            else
            {
                return NotFound("Failed to read or parse the JSON file.");
            }
        }
    }
}
