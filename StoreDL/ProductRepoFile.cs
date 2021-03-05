using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;

namespace StoreDL
{
    public class ProductRepoFile : IProductRepsitory
    {
        private string jsonString;
        private string filePath = "../StoreDL/ProductRepoFile.json";
        public Product AddProduct(Product newProduct)
        {
            List<Product> productsFromFile = GetProducts();
            productsFromFile.Add(newProduct);
            jsonString = JsonSerializer.Serialize(productsFromFile);
            File.WriteAllText(filePath, jsonString);
            return newProduct;
            
        }   

        public Product GetProductByName(string name)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProducts()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new List<Product>();
            }
            return JsonSerializer.Deserialize<List<Product>>(jsonString);

        }
    }
}