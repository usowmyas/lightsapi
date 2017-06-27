using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LightsApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/lights
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "lights1", "lights2" };
        }

        // GET api/values/5
        [HttpGet("{uid}")]
        public string Get(int uid)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{uid}")]
        public void Put(int uid, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{uid}")]
        public void Delete(int uid)
        {
        }
    }
}
