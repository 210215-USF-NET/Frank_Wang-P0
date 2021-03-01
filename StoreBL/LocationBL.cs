using System.Collections.Generic;
using StoreModels;
using StoreDL;
using StoreBL;
using System;

namespace StoreBL
{
    public class LocationBL : ILocationBL
    {
        private ILocationRepository _repo;

        public LocationBL(ILocationRepository repo)
        {
            _repo = repo;
        }
        
        public void AddLocation(Location newLocation){
            _repo.AddLocation(newLocation);
        }
        public List<Location> GetLocations()
        {
            return _repo.GetLocations();
        }

        public Location GetSpecificLocation(int locationID)
        {
            throw new System.NotImplementedException();
        }
    }

    
}