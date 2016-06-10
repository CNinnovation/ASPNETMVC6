using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPISample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static List<string> _teams = new List<string>() { "Ferrari", "McLaren", "Mercedes" };

        // GET api/values
        [Produces("application/json", "application/xml")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _teams;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _teams[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _teams.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            _teams[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _teams.RemoveAt(id);
        }
    }
}
