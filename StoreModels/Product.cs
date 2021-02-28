namespace StoreModels
{
    public class Product
    {

        private string productName;
        private int productID;
        private double productPrice;


        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }

        public Chips ChipsType { get; set; }

    }
}