using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        #nullable enable
        public string? Box { get; set; }
        #nullable disable

        public Cities City { get; set; }
        
        public Country Country { get; set; }
    }
}
