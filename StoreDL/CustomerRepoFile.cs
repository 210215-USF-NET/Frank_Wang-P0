using System.Collections.Generic;
using System;
using System.IO;
using System.Text.Json;
using StoreModels;


namespace StoreDL
{
    public class CustomerRepoFile : ICustomerRepository
    {
        private string jsonString;
        private string filePath = "./StoreDL/CustomerFiles.json";
        {
            List<Customer> customerFromFile = GetCustomer();
            customerFromFile.Add(newCustomer);
            jsonString = JsonSerializer.Serialize(customerFromFile);
            File.WriteAllText(filePath, jsonString);
            return newCustomer;

        }
    

     
        public List<Customer> GetCustomer()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                
               return new List<Customer>();
            }
         
            return JsonSerializer.Deserialize<List<Customer>>(jsonString);
        }
}
