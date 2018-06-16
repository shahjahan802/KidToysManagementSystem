using System;
using System.Collections.Generic;

namespace FirstAssignmentTheta.Models
{
    public partial class EmailSender
    {
        public long Id { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
