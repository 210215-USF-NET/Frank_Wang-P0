using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public class OrderRepoStorageSC : IOrderRepository
    {
        public List<Order> GetOrders()
        {
            return Storage.AllOrders;
        }
        public Order AddOrder(Order newOrder)
        {
            Storage.AllOrders.Add(newOrder);
            return newOrder;
        }

        public Order GetOrderByName(string name)
        {
            throw new System.NotImplementedException();
        }

    }
}