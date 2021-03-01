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

    }
}