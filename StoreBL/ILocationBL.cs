using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface ILocationBL
    {
        List<Location> GetLocations();
        Location GetSpecificLocation(int locationID);

        void AddLocation(Location newLocation);
    }
}