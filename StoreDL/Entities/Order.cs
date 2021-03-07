using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int ProdID { get; set; }
        public int OrderQuantity { get; set; }
        public double OrderTotal { get; set; }
    }
}
