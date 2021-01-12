using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string ContactType { get; set; }
        public string ContactInformation { get; set; }
        public string Description { get; set; }
    }
}
