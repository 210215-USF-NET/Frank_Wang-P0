using System;
using StoreModels;
using StoreBL;
using StoreDL;
using System.Collections.Generic;


namespace StoreUI
{
    public class CustomerMenu : IMenu
    {
        
            private ICustomerBL _customerBL;
            private ILocationBL _locationBL;
            private IOrderBL _orderBL;
            private IProductBL _productBL;
            private IInventoryBL _inventoryBL;
            public CustomerMenu(ICustomerBL customerBL,ILocationBL locationBL,IOrderBL orderBL,IProductBL productBL, IInventoryBL InventoryBL)
            {
                _customerBL = customerBL;
                _locationBL = locationBL;
                _orderBL = orderBL;
                _productBL = productBL;
                _inventoryBL = InventoryBL;
                
            }

            public Customer currentCustomer = new Customer();
            public Location currentLocation = new Location();
            public Product currentProduct = new Product();
            
            
        
        public void Start()
        {
            Boolean stay = true;

            do{

            Console.WriteLine("Welcome Customer! What Would You Like To Do? ");
            Console.WriteLine("[0] New Customer");
            Console.WriteLine("[1] Search for Customers");
            Console.WriteLine("[2] Place New Order");
            Console.WriteLine("[3] Search for Location");
            Console.WriteLine("[4] View Order History");
            Console.WriteLine("[5] View Location History");

            Console.WriteLine("[9] Exit Menu");
            String userInput = Console.ReadLine();

            switch(userInput){

                case "0":
                        CreateCustomer();                    
                        break;

                case "1":
                        CustomerSearch();
                        break;

                case "2":

                        CreateOrder();
                        break;

                case "3":

                        SearchLocation();
                        break;
                case "4":

                        OrderHistory();
                        break;
                case "5":

                        LocationHistory();
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

            public void CustomerSearch()
            {
            Console.WriteLine("Enter your Phone Number: ");
            Customer foundCustomer = _customerBL.GetCustomerByName(Console.ReadLine());
            if (foundCustomer == null)
            {
                Console.WriteLine("No customer with that [Phone Number] exists in our Database, register or try again.");
            }
            else
            {
                Console.WriteLine(foundCustomer.ToString());
            }
            }

            public void CreateOrder()
            {
            Console.WriteLine("Enter your Phone Number: ");
            Customer foundCustomer = _customerBL.GetCustomerByName(Console.ReadLine());
            if (foundCustomer == null)
            {
                Console.WriteLine("No customer with that [Phone Number] exists in our Database. Please register to create an order.");
            }
            else
            {
                Console.WriteLine($"{foundCustomer} \n\t");
                Console.WriteLine("Here is a list of our products: ");

            
                foreach (var item in _productBL.GetProduct())
            
            {
                Console.WriteLine(item.ToString());
            }
                double total;
                Order newOrder = new Order();
                Product P = new Product();
                newOrder.Customer = foundCustomer;
                //Console.WriteLine($"{newOrder.Customer}");
                //Console.WriteLine($"{newOrder.Customer.PhoneNumber}");
                //currentLocation = SearchLocation(Console.ReadLine());
                newOrder.Location = currentLocation;
                Console.WriteLine("Enter the Name of the product you would like to purchase: ");
                Console.WriteLine("[1] Original");
                Console.WriteLine("[2] Barbeque");
                Console.WriteLine("[3] Salt and Vinegar");
                Console.WriteLine("[4] Sour Cream and Onion");
                Product selectProduct = _productBL.GetProductByName(Console.ReadLine());
                newOrder.Product = selectProduct;
                //newOrder.OrderID = int.Parse(Console.ReadLine());
                Console.WriteLine($"You have ordered item #{selectProduct.ProductID}, price {selectProduct.ProductPrice}");
                Console.WriteLine("Select the quantity: ");
                newOrder.OrderQuantity = int.Parse(Console.ReadLine());

                total = newOrder.OrderQuantity * (double)selectProduct.ProductPrice;
                newOrder.OrderTotal = total;
                Console.WriteLine($"total: {newOrder.OrderTotal}");

                _orderBL.AddOrder(newOrder);
                Console.WriteLine($"You have Successfully Placed your order! Total: [{newOrder.OrderTotal}]");

                

            }
            
            }

            public void SearchLocation()
            {
                foreach (var item in _locationBL.GetLocations())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            }

            public void OrderHistory()
            {
                foreach (var item in _orderBL.GetOrder())
                {
                    Console.WriteLine(item.ToString());
                }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
            }

            public void LocationHistory()
            {
                Console.WriteLine("Feature Coming Soon!");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }
            

            
            


        }
    }

