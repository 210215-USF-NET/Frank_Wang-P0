using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? Customer { get; set; }
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
    }
}
