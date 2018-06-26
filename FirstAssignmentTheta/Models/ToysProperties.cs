using System;
using System.Collections.Generic;

namespace FirstAssignmentTheta.Models
{
    public partial class ToysProperties
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Weight { get; set; }
        public long? Age { get; set; }
        public string Email { get; set; }
        public string File { get; set; }
    }
}
