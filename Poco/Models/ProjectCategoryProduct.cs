using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class ProjectCategoryProduct
    {
        public int Project_CategoryId {get; set;}

        public int ProductId { get; set; }

#nullable enable
        public string? Code {get; set;}
#nullable disable

        public int SupplierId {get; set;}
    }
}
