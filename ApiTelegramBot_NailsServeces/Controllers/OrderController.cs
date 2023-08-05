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
    public class OrderController : ControllerBase
    {
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            TBotContext db = new TBotContext();
            return db.Orders.ToList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            TBotContext db = new TBotContext();
            return db.Orders.Find(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            using TBotContext db = new TBotContext();
            db.Orders.Add(order);
            db.SaveChanges();
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order newOrder)
        {
            using TBotContext db = new TBotContext();
            Order order = db.Orders.Find(id);

            if (order != null)
            {
                order = newOrder;
                //обновляем объект
                db.Orders.Update(order);
                db.SaveChanges();
            }
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using TBotContext db = new TBotContext();
            Order order = db.Orders.Find(id);
            // получаем первый объект
            if (order != null)
            {
                //удаляем объект
                db.Orders.Remove(order);
                db.SaveChanges();
            }
        }
    }
}
