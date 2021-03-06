using Model = StoreModels;
using Entity = StoreDL.Entities;


namespace StoreDL
{
    /// <summary>
    ///  To Parse Entity from database to models and used in BL
    /// </summary>
    public interface IMapper
    {
        Model.Customer ParseCustomer(Entity.Customer customer);
        Entity.Customer ParseCustomer(Model.Customer customer);
        Model.Location ParseLocations(Entity.Location location);
        Entity.Location ParseLocations(Model.Location location);
        Model.Product ParseProduct(Entity.Product product);
        Entity.Product ParseProduct(Model.Product product);

        Model.Inventory ParseInventory(Entities.Inventory inventory);
        Entities.Inventory ParseInventory(Model.Inventory inventory);

        Model.Order ParseOrder(Entities.Order order);
        Entities.Order ParseOrder(Model.Order order);
    }
}