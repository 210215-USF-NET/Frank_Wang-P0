using System;
using System.Collections.Generic;
using StoreModels;
using StoreDL;



namespace StoreBL
{
    public class CustomerBL : ICustomerBL
    

    {
        private ICustomerRepository _repo;
        public CustomerBL(ICustomerRepository repo)
        {
            _repo = repo;
        }
        public void AddCustomer(Customer newCustomer)
        {
            _repo.AddCustomer(newCustomer);
        }

        public List<Customer> GetCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();


    }
}
}
