using StoreModels;
using System.Collections.Generic;

namespace StoreDL
{
    public interface IProductRepsitory
    {
        List<Product> GetProducts();
        Product AddProduct(Product newProduct);
        Product GetProductByName(string name);
    }
}