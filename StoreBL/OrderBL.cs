using System.Collections.Generic;
using StoreModels;
using StoreDL;
using System;
namespace StoreBL
{
    public class OrderBL : IOrderBL
    {
        private IOrderRepository _repo;
        public OrderBL(IOrderRepository repo)
        {
            _repo = repo;
        }
        
        public void AddOrder(Order newOrder)
        {
            _repo.AddOrder(newOrder);
        }

        public Order GetOrdersByName(string name)
        {
            return _repo.GetOrdersByName(name);
        }
        public List<Order> GetOrders()
        {
            return _repo.GetOrders();
        }
    }
}
