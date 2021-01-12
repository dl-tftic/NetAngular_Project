using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        #nullable enable
        public int? ParentCategoryProductId { get; set; }
        #nullable disable
        public int ProductId { get; set; }
    }
}
