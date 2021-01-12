using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int ParentCategoryProductId { get; set; }
    }
}
