using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface IOrderBL
    {
        List<Order> GetOrder();
        

        void AddOrder(Order newOrder);
        //Order GetOrderByName(string name);
    }
}