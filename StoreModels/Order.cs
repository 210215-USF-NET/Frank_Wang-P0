namespace StoreModels
{
    public class Order
    {
        private Customer customer;
        private Location location;
        private double total;
        private int orderID;
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public double Total { get; set; }
        public int OrderID { get; set; }
    }
}