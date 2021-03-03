using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;


namespace StoreBL

{
    public interface ICustomerBL 
    {
        List <Customer> GetCustomer();
        void AddCustomer(Customer newCustomer);

        Customer GetCustomerByName(string name);
        
    }
}
