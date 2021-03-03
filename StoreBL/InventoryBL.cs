using System.Collections.Generic;
using StoreModels;
using StoreDL;
using StoreBL;
using System;

namespace StoreBL
{
    public class InventoryBL : IInventoryBL
    {
        private IInventoryRepository _repo;

        public InventoryBL(IInventoryRepository repo)
        {
            _repo = repo;
        }
        public void AddInventory(Inventory newInventory)
        {
            _repo.AddInventory(newInventory);
        }

        public List<Inventory> GetInventories()
        {
            return _repo.GetInventories();
        }
    }
}