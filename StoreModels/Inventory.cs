using System;

namespace StoreModels
{
    public class Inventory
    {
        private int inventoryID;
        private int locationIdentity;
        private int inventoryQuantity;

        public int InventoryID { get; set; }
        public int LocationIdentity{get; set;}
        public int InventoryQuantity {get; set; }

        public Location Location {get; set; }
        public Product Product{ get; set;}


        public override string ToString() => $"Inventory Details:\n\tStore: {this.LocationIdentity} \n\tInventoryID: {this.InventoryID} \n\tProduct Quantity: {this.InventoryQuantity}";
        }
    }
