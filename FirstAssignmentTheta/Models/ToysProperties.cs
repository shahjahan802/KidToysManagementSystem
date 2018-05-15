using System;
using System.Collections.Generic;

namespace FirstAssignmentTheta.Models
{
    public partial class ToysProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }
        public int? Age { get; set; }
    }
}
