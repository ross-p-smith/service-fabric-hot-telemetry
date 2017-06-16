using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasicService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            ServiceEventSource.Current.Message("Values Controller called.");
            return new string[] { "value1", "value2" };
        }
    }
}
