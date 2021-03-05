using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using StoreModels;
using StoreDL.Entities;


namespace StoreDL
{
    public class StoreMapper : IMapper
    {
        public Model.Customer ParseCustomer(Entity.Customer customer)
        {
            return new Model.Customer
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            PhoneNumber = customer.PhoneNumber
        };
        }

        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            return new Entity.Customer
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            PhoneNumber = customer.PhoneNumber
        };
        }

        public Model.Location ParseLocations(Entity.Location location)
        {
            throw new System.NotImplementedException();
        }

        public Entity.Location ParseLocations(Model.Location location)
        {
            throw new System.NotImplementedException();
        }

        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product
            {
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductID = product.ProductID,
                ProductPrice = (double)product.ProductPrice

            };
        }

        public Entity.Product ParseProduct(Model.Product product)
        {
            return new Entity.Product
            {
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductID = product.ProductID,
                ProductPrice = (decimal)product.ProductPrice
            };
        }

        public Model.Inventory ParseInventory(Entity.Inventory inventory)
        {
            return new Model.Inventory
            {
                LocationIdentity =  inventory.LocationIdentity,
                InventoryID =  inventory.InventoryID,
                InventoryQuantity =  inventory.InventoryQuantity

            };
        }
        public Entity.Inventory ParseInventory(Model.Inventory inventory)
        {
            return new Entity.Inventory
        {
            LocationIdentity = inventory.LocationIdentity,
            InventoryID = inventory.InventoryID,
            InventoryQuantity = inventory.InventoryQuantity
        };
        }
        
    }
}