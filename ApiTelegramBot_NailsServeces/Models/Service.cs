//using Microsoft.EntityFrameworkCore;
namespace FM_TelegramBotWebApi.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Duration { get; set; }
    }
}