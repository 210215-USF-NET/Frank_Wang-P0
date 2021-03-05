using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;

namespace StoreDL
{
    public class InventoryRepoFile : IInventoryRepository
    {
        private string jsonString;
        private string filePath = "../StoreDL/InventoryRepoFile.json";
        public Inventory AddInventory(Inventory newInventory)
        {
            List<Inventory> inventoriesFromFile = GetInventories();
            inventoriesFromFile.Add(newInventory);
            jsonString = JsonSerializer.Serialize(inventoriesFromFile);
            File.WriteAllText(filePath, jsonString);
            return newInventory;
        }

        public Inventory GetInventoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Inventory> GetInventories()
        {
            try{
                jsonString = File.ReadAllText(filePath);
            }
            catch(Exception)
            {
                return new List<Inventory>();
            }

            return JsonSerializer.Deserialize<List<Inventory>>(jsonString);
        }
    }
}