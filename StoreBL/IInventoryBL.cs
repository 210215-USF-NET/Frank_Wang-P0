using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface IInventoryBL
    {
        List<Inventory> GetInventories();

        void AddInventory(Inventory newInventory);
    }
}