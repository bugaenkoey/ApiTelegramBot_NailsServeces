using FM_TelegramBotWebApi.Models;
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
    public class ServiceController : ControllerBase
    {
        // GET: api/<ServiceController>
        [HttpGet]
        public IEnumerable<Service> Get()
        {
            TBotContext db = new TBotContext();
            return db.Services.ToList();
        }

        // GET api/<ServiceController>/5
        [HttpGet("{id}")]
        public Service Get(int id)
        {
            TBotContext db = new TBotContext();
            return db.Services.Find(id);
        }

        // POST api/<ServiceController>
        [HttpPost]
        public void Post([FromBody] Service service)
        {
            using TBotContext db = new TBotContext();
            db.Services.Add(service);
            db.SaveChanges();
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Service newService)
        {
            using TBotContext db = new TBotContext();
             Service service = db.Services.Find(id);

            if (service != null)
            {
                service = newService;
                //обновляем объект
                db.Services.Update(service);
                db.SaveChanges();
            }
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using TBotContext db = new TBotContext();
            Service service = db.Services.Find(id);
            // получаем первый объект
            if (service != null)
            {
                //удаляем объект
                db.Services.Remove(service);
                db.SaveChanges();
            }
        }
    }
}
