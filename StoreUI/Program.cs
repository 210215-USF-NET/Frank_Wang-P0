using System;
using StoreModels;
using StoreDL;
using StoreBL;



namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {

            
            IMenu menu = new MainMenu(new CustomerBL(new CustomerRepoFile()), new LocationBL(new LocationRepoFile()), new OrderBL(new OrderRepoFile()), new ProductBL(new ProductRepoFile()));
            menu.Start();
        }
    }
}


