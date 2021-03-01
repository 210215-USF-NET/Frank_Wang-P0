using System.Collections.Generic;
using StoreModels;
using System;
using StoreDL;


namespace StoreBL
{
    public class ProductBL : IProductBL
    {
        private IProductRepsitory _repo;
        public ProductBL(IProductRepsitory repo){
            _repo = repo;
        }

        public void AddProduct(Product newProduct)
        {
            _repo.AddProduct(newProduct);
        }
        public List<Product> GetProducts()
        {
            return _repo.GetProducts();
        }
    }
}