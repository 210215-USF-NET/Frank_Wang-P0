using System;
using StoreModels;
using StoreBL;


namespace StoreUI
{
    public class MainMenu : IMenu
    {
        private IMenu customerMenu;
        private IMenu managerMenu;
        private ICustomerBL _customerBL;

        public MainMenu(ICustomerBL customerBL, ILocationBL locationBL,  IOrderBL orderBL, IProductBL productBL)
        {
            customerMenu = new CustomerMenu(customerBL, locationBL, orderBL, productBL);
            _customerBL = customerBL;
            managerMenu = new ManagerMenu(customerBL, locationBL, orderBL, productBL);

        }
        public void Start(){
            Boolean stay = true;
            do{
                Console.WriteLine("Welcome to the Store! Which User are You?");
                Console.WriteLine("[1] Customer");
                Console.WriteLine("[2] Manager");
                Console.WriteLine("[3] Exit");
                Console.WriteLine("Enter Your Selection: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                        case "1":
                        customerMenu.Start();
                        break;
                    case "2":
                        managerMenu.Start();
                        break;
                    case "3":
                        stay = false;
                        ExitUI();
                        break;
                    default:
                        Console.WriteLine("Choose a Valid Option.");
                        break;
                }
            } while (stay);
        }        

        public void ExitUI()
        {
            Console.WriteLine("Thank You! Please Shop with us again");
        }
      
                
    }
}