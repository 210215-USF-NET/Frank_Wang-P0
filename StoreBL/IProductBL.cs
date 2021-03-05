using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface IProductBL
    {
        List<Product> GetProduct();
        void AddProduct(Product newProduct);

        Product GetProductByName(string name);
    }
}