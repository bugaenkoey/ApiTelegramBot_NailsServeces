using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Telegram.Bot.Types;
using ApiTelegramBot_NailsServeces.Models.InitialData;

namespace FM_TelegramBotWebApi.Models
{
    public class TBotContext : DbContext
    {
        public TBotContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<UserTelegram> UserTelegrams { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TelegramBotFM;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData.SeedService(modelBuilder);
            SeedData.SeedUserTelegram(modelBuilder);
            SeedData.SeedOrders(modelBuilder);
        }

    }
}
