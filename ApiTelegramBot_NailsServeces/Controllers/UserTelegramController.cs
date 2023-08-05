using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTelegramBot_NailsServeces.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTelegramController : ControllerBase
    {
        // GET: api/<UserTelegramController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserTelegramController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserTelegramController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserTelegramController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserTelegramController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
