using System;

namespace StoreModels
{
    public class Inventory
    {
        private string inventoryID;
        private string locationIdentity;
        private int inventoryQuantity;

        public string InventoryID { get; set; }
        public string LocationIdentity{get; set;}
        public int InventoryQuantity {get; set; }

        public Location Location {get; set; }
        public Product Product{ get; set;}
    }
}