using System;
using BLL.Models;

namespace BLL.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable
        public Address Address { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
        
    }
}