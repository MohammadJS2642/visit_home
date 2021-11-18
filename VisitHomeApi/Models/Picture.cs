using System;
using System.Collections.Generic;

namespace VisitHomeApi.Models
{
    public partial class Picture
    {
        public int Id { get; set; }
        public int? HomeId { get; set; }

        public virtual Home Home { get; set; }
    }
}
