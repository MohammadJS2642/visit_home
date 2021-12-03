using System;
using System.Collections.Generic;

namespace VisitHomeApi.Models
{
    public partial class Home
    {
        public string Area { get; set; }
        public string NumberOfBedrooms { get; set; }
        public string Parking { get; set; }
        public string Warehouse { get; set; }
        public string Floor { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string PicturesName { get; set; }
    }
}
