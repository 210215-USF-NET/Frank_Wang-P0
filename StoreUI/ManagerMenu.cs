using System;
using StoreModels;
using StoreBL;
using StoreDL;
using System.Collections.Generic;

namespace StoreUI
{
    public class ManagerMenu : IMenu
    {
            private ICustomerBL _customerBL;
            private ILocationBL _locationBL;
            private IOrderBL _orderBL;
            private IProductBL _productBL;
            private IInventoryBL _inventoryBL;
            public ManagerMenu(ICustomerBL customerBL,ILocationBL locationBL,IOrderBL orderBL,IProductBL productBL, IInventoryBL inventoryBL)
            {
                _customerBL = customerBL;
                _locationBL = locationBL;
                _orderBL = orderBL;
                _productBL = productBL;
                _inventoryBL = inventoryBL;
                
            }
            
            
        
        public void Start()
        {
            Boolean stay = true;

            do{

            Console.WriteLine("Welcome Manager! What Would You Like To Do? ");
            Console.WriteLine("[0] New Product");
            Console.WriteLine("[1] View Inventory");
            Console.WriteLine("[2] Update Inventory");
            Console.WriteLine("[3] View Locations");
            Console.WriteLine("[4] Update Locations");
            Console.WriteLine("[5] Search Customers");

            Console.WriteLine("[9] Exit Menu");
            String userInput = Console.ReadLine();

            switch(userInput){

                case "0":
                        CreateProduct();                    
                        break;

                case "1":
                        InventoryView();
                        break;

                case "2":

                        UpdateInventory();
                        break;

                case "3":

                        ViewLocations();
                        break;
                case "4":

                        UpdateLocations();
                        break;
                case "5":

                        SearchCustomers();
                        break;
                case "9":
                        stay = false;
                        System.Environment.Exit(0);
                        break;
                default :
                Console.WriteLine("Not a valid menu option!");
                break;
            }
        } while(stay);


            }
            public void CreateProduct()
            {
            Product newProduct = new Product();
            Console.WriteLine("Enter Product Name: ");
            newProduct.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Details: ");
            newProduct.ProductDescription = Console.ReadLine();
            Console.WriteLine("Enter Product ID (####): ");
            newProduct.ProductID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Price: ");
            newProduct.ProductPrice = double.Parse(Console.ReadLine());
            
            
            _productBL.AddProduct(newProduct);
            Console.WriteLine($"Product {newProduct.ProductName} created successfully!");
            
            }

            public void InventoryView()
            {
                foreach (var item in _inventoryBL.GetInventories())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            }

            public void UpdateInventory()
            {
                Console.WriteLine("Feature Coming Soon!");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }

            public void ViewLocations()
            {
                foreach (var item in _locationBL.GetLocations())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            }

            public void UpdateLocations()
            {
            Location newLocation = new Location();
            Console.WriteLine("Enter New Location Address: ");
            newLocation.LocationAddress = Console.ReadLine();
            Console.WriteLine("Enter Location ID (##): ");
            newLocation.LocationID = int.Parse(Console.ReadLine());

            _locationBL.AddLocation(newLocation);
            Console.WriteLine($"New Location {newLocation.LocationAddress} created successfully!");

            }

            public void SearchCustomers()
            {
                foreach (var item in _customerBL.GetCustomer())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            }


        }
    }
    
