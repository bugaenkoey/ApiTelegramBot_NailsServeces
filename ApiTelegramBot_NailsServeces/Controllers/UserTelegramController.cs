using FM_TelegramBotWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTelegramBot_NailsServeces.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTelegramController : ControllerBase
    {
        //private readonly UserTelegram userTelegram1;

        //public UserTelegramController(UserTelegram userTelegram1)
        //{
        //    this.userTelegram1 = userTelegram1;
        //}

        // GET: api/<UserTelegramController>
        [HttpGet]
        public IEnumerable<UserTelegram> Get()
        {
            TBotContext db = new TBotContext();
            return db.UserTelegrams.ToList();
        }

        // GET api/<UserTelegramController>/5
        [HttpGet("{id}")]
        public UserTelegram Get(int id)
        {
            TBotContext db = new TBotContext();
            return db.UserTelegrams.Find(id);
        }

        // POST api/<UserTelegramController>
        [HttpPost]
        public void Post([FromBody] UserTelegram userTelegram)
        {
            using TBotContext db = new TBotContext();
            db.UserTelegrams.Add(userTelegram);
            db.SaveChanges();
        }

        // PUT api/<UserTelegramController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserTelegram newUserTelegram)
        {
            using TBotContext db = new TBotContext();
            UserTelegram userTelegram = db.UserTelegrams.Find(id);

            if (userTelegram != null)
            {
                userTelegram = newUserTelegram;
                //обновляем объект
                db.UserTelegrams.Update(userTelegram);
                db.SaveChanges();
            }
        }

        // DELETE api/<UserTelegramController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using TBotContext db = new TBotContext();
            UserTelegram userTelegram = db.UserTelegrams.Find(id);
            // получаем первый объект
            if (userTelegram != null)
            {
                //удаляем объект
                db.UserTelegrams.Remove(userTelegram);
                db.SaveChanges();
            }
        }
    }
}
