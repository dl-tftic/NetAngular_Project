using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Cities
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
    }
}
