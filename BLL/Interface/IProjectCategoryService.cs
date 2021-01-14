using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;


namespace BLL.Interface
{
    public interface IProjectCategoryService
    {
        public List<ProjectCategory> Get(int projectId);
    }
}
