using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interface;

namespace BLL.Models
{
    class ProjectCategory : Category
    {
        public List<ProjectCategory> SubCategories { get; set; }

        public List<Files> Files { get; set; }

        public List<Product> Products { get; set; }
    }
}
