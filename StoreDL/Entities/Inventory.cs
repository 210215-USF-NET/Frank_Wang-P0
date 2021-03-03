using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int LocationIdentity { get; set; }
        public int InventoryID { get; set; }
        public int InventoryQuantity { get; set; }
    }
}
