using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Iso { get; set; }
        public string Name { get; set; }
#nullable enable
        public string? Iso3 { get; set; }

        public Int16? NumCode { get; set; }
#nullable disable
        public int PhoneCode { get; set; }
    }
}
