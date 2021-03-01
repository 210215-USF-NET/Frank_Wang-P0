namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties for store locations
    /// </summary>
    public class Location
    {
        private string locationAddress;
        private int locationID;
        public string LocationAddress { get; set; }
        public int LocationID { get; set; }
    
        public override string ToString() => $"Location Details:\n\tAddress: {this.LocationAddress} \n\tLocationID: {this.LocationAddress}";
    }
}