using System;
using StoreModels;
using StoreBL;


namespace StoreUI
{
    public class MainMenu : IMenu
    {
        private ICustomerBL _customerBL;

        public MainMenu(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
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
                        CreateCustomer();
                        break;
                    case "2":
                        //managermenu
                        break;
                    case "3":
                        ExitUI();
                        break;
                    default:
                        Console.WriteLine("Choose a Valid Option.");
                        break;
                }
            } while (stay);
        }        
        public void CreateCustomer()
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter Your First Name: ");
            newCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter Your Phone Number ((###)-###-####): ");
            newCustomer.PhoneNumber = Console.ReadLine();
            _customerBL.AddCustomer(newCustomer);
            Console.WriteLine($"Added Customer, {newCustomer.FirstName} {newCustomer.LastName} !");
        }
        public void ExitUI()
        {
            Console.WriteLine("Thank You! Please Shop with us again");
        }

        public void CreateOrder()
        {

            

        }
        
                
    }
}