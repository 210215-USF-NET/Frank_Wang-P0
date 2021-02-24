using System;
using StoreModels;
using StoreBL;


namespace StoreUI
{
    public class MainMenu : IMenu
    {
        Boolean stay = true;
        public MainMenu(){

        }

        public void End(){
            active = false;
        }

        public void Start(){
            do{
                Console.WriteLine("Please Select an Option Below: ");
                Console.WriteLine("[1] New Order");
                Console.WriteLine("[2] Contact Support");
                Console.WriteLine("[3] Exit");
                Console.WriteLine("Enter Your Selection: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                        case "1":
                        CustomerInfo();
                        break;
                    case "2":
                        //Support
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
        public void CustomerInfo()
        {

        }
        public void ExitUI()
        {}
        
                
    }
}