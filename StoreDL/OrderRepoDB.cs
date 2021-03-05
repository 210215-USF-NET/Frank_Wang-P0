using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using StoreModels;

namespace StoreDL
{
    public class OrderRepoDB :IOrderRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;

        public OrderRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Order AddOrder(Model.Order newOrder)
        {
            _context.Orders.Add(_mapper.ParseOrder(newOrder));
            _context.SaveChanges();
            return newOrder;
        }

        //public Order GetOrderByName(string name)
        //{
            //return _context.Orders
            //.Select(x => _mapper.ParseOrder(x))
            //.ToList()
            //.FirstOrDefault(x => x.OrderID == name);  
        //}

        public List<Order> GetOrders()
        {
            return _context.Orders.Select(x => _mapper.ParseOrder(x)).ToList();
        }
    }
}