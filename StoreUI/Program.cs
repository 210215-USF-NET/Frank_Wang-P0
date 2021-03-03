using System;
using StoreModels;
using StoreDL;
using StoreBL;
using StoreDL.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;



namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            string connectionString = configuration.GetConnectionString("StoreDB");
            DbContextOptions<StoreDBContext> options = new DbContextOptionsBuilder<StoreDBContext>()
            .UseSqlServer(connectionString)
            .Options;

            using var context = new StoreDBContext(options);
            
            IMenu menu = new MainMenu(new CustomerBL(new CustomerRepoDB(context, new StoreMapper())), new LocationBL(new LocationRepoFile()), new OrderBL(new OrderRepoFile()), new ProductBL(new ProductRepoFile()), new InventoryBL(new InventoryRepoDB(context, new StoreMapper())));
            menu.Start();
        }
    }
}


