using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface IProductBL
    {
        List<Product> GetProducts();
    }
}