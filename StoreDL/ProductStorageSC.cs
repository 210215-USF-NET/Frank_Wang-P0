using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public class ProductStorageSC : IProductRepsitory
    {
        public List<Product> GetProducts()
        {
            return Storage.AllProducts;
        }
        public Product AddProduct(Product newProduct)
        {
            Storage.AllProducts.Add(newProduct);
            return newProduct;
        }

        public Product GetProductByName(string name)
        {
            throw new System.NotImplementedException();
        }


    }
}