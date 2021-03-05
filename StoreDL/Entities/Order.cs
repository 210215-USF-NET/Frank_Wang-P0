using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? Customer { get; set; }
        public int OrderID { get; set; }
        public int OrderQuantity { get; set; }
        public double OrderTotal {get; set;}

        public virtual Customer CustomerNavigation { get; set; }
    }
}
