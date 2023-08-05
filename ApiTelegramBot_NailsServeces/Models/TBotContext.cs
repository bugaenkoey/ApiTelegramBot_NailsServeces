using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

using Telegram.Bot.Types;

namespace FM_TelegramBotWebApi.Models
{
    public class TBotContext : DbContext
    {

        //public TBotContext() => Database.EnsureCreated();

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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=helloapp.db");
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //string StringConect = @"Data Source=.\SQLEXPRESS;Integrated Security=True;";

        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TbotFM;Trusted_Connection=True;");
        //    // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FavoriteMaster;Trusted_Connection=True;");
        //}
    }
}
