using System.Collections.Generic;
using StoreModels;
using System.IO;
using System.Text.Json;
using System;


namespace StoreDL
{
    public class LocationRepoFile : ILocationRepository
    {
        private string jsonString;
        private string filePath = "../StoreDL/LocationRepoFile.json";
        public Location AddLocation(Location newLocation)
        {
            List<Location> locationsFromFile = GetLocations();
            locationsFromFile.Add(newLocation);
            jsonString = JsonSerializer.Serialize(locationsFromFile);
            File.WriteAllText(filePath, jsonString);
            return newLocation;
            
        }


        public Location GetLocationByName(string name)
        {
            throw new NotImplementedException();
        }
        public List<Location> GetLocations()

        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                return new List<Location>();
            }
            return JsonSerializer.Deserialize<List<Location>>(jsonString);

        }
    }
}