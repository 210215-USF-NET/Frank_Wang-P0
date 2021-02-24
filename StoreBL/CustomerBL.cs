using System;
using System.Collections.Generic;
using StoreModels;
using StoreDL;



namespace StoreBL
{
    public class CustomerBL : ICustomerBL;
    

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

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();


    }
}
}
    public override bool Equals(object obj)
    {
        return obj is CustomerBL bL &&
               EqualityComparer<ICustomerRepository>.Default.Equals(_repo, bL._repo);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_repo);
    }
