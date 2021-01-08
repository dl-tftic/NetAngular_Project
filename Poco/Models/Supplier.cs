using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
        public int AddressId { get; set; }
    }
}
