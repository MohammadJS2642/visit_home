using System;
using System.Collections.Generic;

namespace VisitHomeApi.Models
{
    public partial class HomePicture
    {
        public string PictureName { get; set; }
        public Guid? HomeId { get; set; }

        public virtual Home Home { get; set; }
    }
}
