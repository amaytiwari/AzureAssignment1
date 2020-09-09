using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

 

namespace SimpleWebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        // GET: api/MyController>
        [HttpGet("profile")]
        public IEnumerable<string> Get()
        {
            return new string[] { "amay", "23" };
        }

        // GET api/<MyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
