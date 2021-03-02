using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Location
    {
        public int Id { get; set; }
        public string LocationAddress { get; set; }
        public int LocationId { get; set; }
    }
}
