using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using StoreModels;

namespace StoreDL
{
    public class InventoryRepoDB : IInventoryRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;

        public InventoryRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Inventory AddInventory(Model.Inventory newInventory)
        {
            _context.Inventories.Add(_mapper.ParseInventory(newInventory));
            _context.SaveChanges();
            return newInventory;
        }

        public List<Model.Inventory> GetInventories()
        {
            return _context.Inventories.Select(x => _mapper.ParseInventory(x)).ToList();
        }
    }
}