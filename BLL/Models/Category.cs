using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

#nullable enable
        public string? Description { get; set; }
        public string? Type { get; set; }
#nullable disable

        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
    }
}
