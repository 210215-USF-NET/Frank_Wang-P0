using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface IOrderBL
    {
        List<Order> GetOrders();

        void AddOrder(Order newOrder);
        Order GetOrdersByName(string name);
    }
}