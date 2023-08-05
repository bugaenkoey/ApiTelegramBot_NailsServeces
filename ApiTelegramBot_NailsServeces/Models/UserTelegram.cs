using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace FM_TelegramBotWebApi.Models
{
    public class UserTelegram : Telegram.Bot.Types.User
    {
        public UserTelegram()
        {
            
        }
        
        //public long BaseId { get => base.Id; set => base.Id = BaseId; }
        public int Role { get; set; } = (int)ROLES.Guest;
        //public ROLES ROLE { get; set; } = ROLES.Guest;
        public ICollection<Order> Orders { get; set; }
        
    }
}
