using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Iso { get; set; }
        public string Name { get; set; }
        public string iso3 { get; set; }
        public short? NumCode { get; set; }
        public int PhoneCode { get; set; }
    }

}
