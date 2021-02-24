using System;
using StoreModels;


namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu customer = new MainMenu(new CustomerBL(new CustomerRepoFile));
            customer.Start();
        }
    }
}
