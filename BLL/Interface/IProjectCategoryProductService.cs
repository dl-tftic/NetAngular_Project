using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface IProjectCategoryProductService
    {
        public List<ProjectCategoryProduct> GetByProjectCategory(int projectCategoryId);
    }
}
