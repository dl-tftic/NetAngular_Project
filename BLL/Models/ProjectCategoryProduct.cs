using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class ProjectCategoryProduct
    {
        public ProjectCategoryProduct()
        {

        }

        public ProjectCategoryProduct(int productId, int supplierId)
        {
            this._productId = productId;
            this._supplierId = supplierId;
        }

        private int _supplierId;
        private int _productId;
        public int Project_CategoryId { get; set; }

        public Product Product { get; set; }

#nullable enable
        public string? Code { get; set; }
#nullable disable

        public Supplier Supplier { get; set; }

        public int GetProductId()
        {
            return this._productId;
        }

        public int GetSupplierId()
        {
            return this._supplierId;
        }
    }
}
