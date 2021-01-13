using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

#nullable enable
        public string? Code { get; set; }
        public string? Description { get; set; }
#nullable disable

        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
        public int AddressId { get; set; }
    }
}
