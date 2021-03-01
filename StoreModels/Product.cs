namespace StoreModels
{
    public class Product
    {

        private string productName;
        private int productID;

        private string productDescription;
        private double productPrice;


        public string ProductName { get; set; }
        public int ProductID { get; set; }

        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }

        public Chips ChipsType { get; set; }

        public override string ToString() => $"Product Details:\n\tName: {this.ProductName} \n\tProduct Description: {this.ProductDescription} \n\tProduct ID: {this.ProductID} \n\tProduct Price: {this.ProductPrice}";
    }
}