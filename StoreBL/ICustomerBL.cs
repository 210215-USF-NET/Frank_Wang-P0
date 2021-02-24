using System;
using StoreModels;


namespace StoreBL

{
    public interface ICustomerBL 
    {
        List <Customer> GetCustomer();
        void AddCustomer(Customer newCustomer);
    }
}
