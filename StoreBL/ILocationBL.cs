using System;
using StoreModels;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface ILocationBL
    {

        List<Location> GetLocations();


        void AddLocation(Location newLocation);
        Location GetLocationByName(string name);
    }
}