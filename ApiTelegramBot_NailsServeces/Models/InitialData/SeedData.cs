using FM_TelegramBotWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTelegramBot_NailsServeces.Models.InitialData
{
    public static class SeedData
    {
        public static void SeedService(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = -1, Name = "Зняття", Description = "Зняття", Price = 100, Duration = 1 },
                new Service { Id = -2, Name = "Манікюр", Description = "Манікюр", Price = 300, Duration = 2 },
                new Service { Id = -3, Name = "Гель лак", Description = "Гель лак", Price = 450, Duration = 3 },
                new Service { Id = -4, Name = "Корекція", Description = "Корекція", Price = 480, Duration = 4 },
                new Service { Id = -5, Name = "Нарощування", Description = "Нарощування", Price = 550, Duration = 5 },
                new Service { Id = -6, Name = "Викладний френч", Description = "Викладний френч", Price = 650, Duration = 6 },
                new Service { Id = -7, Name = "Інше", Description = "Інше", Price = 0, Duration = 0 }

                );

        }
        
        public static void SeedUserTelegram(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<UserTelegram>().HasData(
                new UserTelegram { Id = -8, Username = "@Guest_0", FirstName = "Guest_0", Role = 0 },
                new UserTelegram { Id = -1, Username = "@User0_1", FirstName = "User0_1", Role = 1 },
                new UserTelegram { Id = -2, Username = "@Admin_2", FirstName = "Admin_2", Role = 2 },
                new UserTelegram { Id = -3, Username = "@SuperAdmin_3", FirstName = "SuperAdmin_3", Role = 3 },
                new UserTelegram { Id = -4, Username = "@User1_1", FirstName = "User1_1", Role = 1 },
                new UserTelegram { Id = -5, Username = "@User2_1", FirstName = "User2_1", Role = 1 },
                new UserTelegram { Id = -6, Username = "@User3_1", FirstName = "User3_1", Role = 1 },
                new UserTelegram { Id = -7, Username = "@User4_1", FirstName = "User4_1", Role = 1 }

                );
            */
            
            modelBuilder.Entity<UserTelegram>().HasData(
                new UserTelegram { Id = 598000000, Username = "@Guest_0", FirstName = "Guest_0", Role = 0 },
                new UserTelegram { Id = 598000001, Username = "@User0_1", FirstName = "User0_1", Role = 1 },
                new UserTelegram { Id = 598000002, Username = "@Admin_2", FirstName = "Admin_2", Role = 2 },
                new UserTelegram { Id = 598860749, Username = "@SuperAdmin_3", FirstName = "SuperAdmin_3", Role = 3 },
                new UserTelegram { Id = 598000004, Username = "@User1_1", FirstName = "User1_1", Role = 1 },
                new UserTelegram { Id = 598000005, Username = "@User2_1", FirstName = "User2_1", Role = 1 },
                new UserTelegram { Id = 598000006, Username = "@User3_1", FirstName = "User3_1", Role = 1 },
                new UserTelegram { Id = 598000007, Username = "@User4_1", FirstName = "User4_1", Role = 1 }

                );
            /*
            modelBuilder.Entity<UserTelegram>().HasData(
               new UserTelegram { BaseId = 598000000, Id = -0, Username = "@Guest_0", FirstName = "Guest_0", Role = 0 },
               new UserTelegram { BaseId = 598000001, Id = -1, Username = "@User0_1", FirstName = "User0_1", Role = 1 },
               new UserTelegram { BaseId = 598000002, Id = -2, Username = "@Admin_2", FirstName = "Admin_2", Role = 2 },
               new UserTelegram { BaseId = 598860749, Id = -3, Username = "@SuperAdmin_3", FirstName = "SuperAdmin_3", Role = 3 },
               new UserTelegram { BaseId = 598000004, Id = -4, Username = "@User1_1", FirstName = "User1_1", Role = 1 },
               new UserTelegram { BaseId = 598000005, Id = -5, Username = "@User2_1", FirstName = "User2_1", Role = 1 },
               new UserTelegram { BaseId = 598000006, Id = -6, Username = "@User3_1", FirstName = "User3_1", Role = 1 },
               new UserTelegram { BaseId = 598000007, Id = -7, Username = "@User4_1", FirstName = "User4_1", Role = 1 }

               );
            */

        }
        
        public static void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = -1, ServiceId = -1, UserTelegramId = -0, DateTime = new DateTime(2015, 7,  2, 18, 30, 25), Comment = "It is Ok" },
                new Order { Id = -2, ServiceId = -2, UserTelegramId = -5, DateTime = new DateTime(2017, 8, 12, 18, 30, 25), Comment = "It is Ok" },
                new Order { Id = -3, ServiceId = -3, UserTelegramId = -4, DateTime = new DateTime(2020, 9, 21, 18, 30, 25), Comment = "It is Ok" },
                new Order { Id = -4, ServiceId = -4, UserTelegramId = -3, DateTime = new DateTime(2022, 10, 2, 18, 30, 25), Comment = "It is Ok" },
                new Order { Id = -5, ServiceId = -5, UserTelegramId = -1, DateTime = new DateTime(2022, 11, 8, 18, 30, 25), Comment = "It is Ok" },
                new Order { Id = -6, ServiceId = -6, UserTelegramId = -1, DateTime = new DateTime(2023, 4, 10, 18, 30, 25), Comment = "It is Ok" },
                new Order { Id = -7, ServiceId = -7, UserTelegramId = -3, DateTime = new DateTime(2023, 7, 13, 18, 30, 25), Comment = "It is Ok" }
                );
        }
    }
}
