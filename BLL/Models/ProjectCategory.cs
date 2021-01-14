using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interface;

namespace BLL.Models
{
    public class ProjectCategory : CategoryAbstract<ProjectCategory>
    {

        public ProjectCategory() : base()
        {
            InitProjectCategoryProducts();
        }

        public ProjectCategory(Category category) : base(category)
        {
            InitProjectCategoryProducts();
        }
        public List<ProjectCategoryProduct> ProjectCategoryProducts { get; set; }

        #region function
        private void InitProjectCategoryProducts()
        {
            ProjectCategoryProducts = new List<ProjectCategoryProduct>();
        }
        public void AddProjectCategoryProduct(ProjectCategoryProduct product)
        {
            if (product is null) { }
            else this.ProjectCategoryProducts.Add(product);
        }

        public void AddProjectCategoryProducts(List<ProjectCategoryProduct> projectCategoryProducts)
        {
            foreach (ProjectCategoryProduct projectCategoryProduct in projectCategoryProducts)
            {
                this.AddProjectCategoryProduct(projectCategoryProduct);
            }
        }
        public bool HasProducts()
        {
            return ProjectCategoryProducts.Count > 0;
        }
        #endregion
    }
}
