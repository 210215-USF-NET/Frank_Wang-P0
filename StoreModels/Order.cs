namespace StoreModels
{
    public class Order
    {
        private Customer customer;
        private Location location;
        private Product product;
        private string customerName;
        private double orderTotal;
        private int orderID;
        private int orderQuantity;
        private int prodID;
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public Product Product{ get; set; }
        public string CustomerName{get;set;}
        public int ProdID {get; set;}
        public double OrderTotal { get; set; }
        public int OrderID { get; set; }
        public int OrderQuantity{ get; set;}

        public override string ToString() => $"Customer Details:\n\tCustomer Name: {this.CustomerName} \n\t-------------\n\tProduct ID: {this.ProdID} \n\tOrder Quantity: {this.OrderQuantity} \n\tOrder Total: {(double)this.OrderTotal}";
    }
}