namespace StoreModels
{
    public class Order
    {
        private Customer customer;
        private Location location;
        private Product product;
        private double orderTotal;
        private int orderID;
        private int orderQuantity;
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public Product Product{ get; set; }
        public double OrderTotal { get; set; }
        public int OrderID { get; set; }
        public int OrderQuantity{ get; set;}

        
    }
}