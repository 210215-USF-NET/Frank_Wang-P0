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

        public Customer GetCustomerByName(string name)
        {
            //Check if customer exists
            return _repo.GetCustomerByName(name);
        }
        public List<Customer> GetCustomer()
        {
            return _repo.GetCustomers();
        }


}
}
