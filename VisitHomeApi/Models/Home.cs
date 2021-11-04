using System;
using System.Collections.Generic;

#nullable disable

namespace VisitHomeApi.Models
{
    public partial class Home
    {
        public int Id { get; set; }
        public int? Area { get; set; }
        public int? NumberOfBedrooms { get; set; }
        public bool? Parking { get; set; }
        public bool? Warehouse { get; set; }
        public int? Floor { get; set; }
        public string Address { get; set; }
        public int? Pictures { get; set; }
        public double? Price { get; set; }
    }
}
