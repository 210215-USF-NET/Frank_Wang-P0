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

        public Model.Product ParseProducts(Entity.Product product)
        {
            throw new System.NotImplementedException();
        }

        public Entity.Product ParseProducts(Model.Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}