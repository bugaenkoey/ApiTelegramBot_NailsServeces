//using Microsoft.EntityFrameworkCore;
using System;

namespace FM_TelegramBotWebApi.Models
{
    public class Order
    {

        public int Id { get; set; }
        public Service Service { get; set; }
        public int? ServiceId { get; set; }
        public int? MyUserId { get; set; }
        public UserTelegram User { get; set; }
        public bool Done { get; set; } = false;
        public DateTime? DateTime { get; set; }
        public string? Note { get; set; }
        public string? Comment { get; set; }
    }
}