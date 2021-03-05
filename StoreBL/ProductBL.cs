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


        public Product GetProductByName(string name)
        {
            return _repo.GetProductByName(name);
        }
        public List<Product> GetProduct()
        {
            return _repo.GetProducts();
        }
    }
}