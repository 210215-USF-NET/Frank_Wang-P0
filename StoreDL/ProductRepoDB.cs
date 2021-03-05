using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using StoreModels;

namespace StoreDL
{
    public class ProductRepoDB : IProductRepsitory
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;
        public ProductRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Product AddProduct(Model.Product newProduct)
        {
            _context.Products.Add(_mapper.ParseProduct(newProduct));
            _context.SaveChanges();
            return newProduct;
        }

        public Product GetProductByName(string name)
        {
            return _context.Products
            .Select(x => _mapper.ParseProduct(x))
            .ToList()
            .FirstOrDefault(x => x.ProductName == name); 
        }

        public List<Product> GetProducts()
        {
            return _context.Products.Select(x => _mapper.ParseProduct(x)).ToList();
        }


    }
}