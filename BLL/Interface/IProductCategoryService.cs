using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interface
{
    public interface IProductCategoryService
    {
        public List<ProductCategory> Get(int productId);
    }
}
