using System;
using System.Collections.Generic;
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

        public int Role { get; set; } = (int)ROLES.Guest;
        //public ROLES ROLE { get; set; } = ROLES.Guest;
        public ICollection<Order> Orders { get; set; }

    }
}
