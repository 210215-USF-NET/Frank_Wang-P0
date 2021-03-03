using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public interface IInventoryRepository
    {
        List<Inventory> GetInventories();

        Inventory AddInventory(Inventory newInventory);
    }
}