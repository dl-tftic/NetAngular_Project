using System;
using System.Collections.Generic;
using System.Text;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;
using dto = DTO.Models;
using System.Linq;

namespace BLL.Services
{
    public class ProjectCategoryProductService : IProjectCategoryProductService
    {
        private ProjectCategoryProductRepository _projectCategoryProductRepository = new ProjectCategoryProductRepository();

        private IProductService _productService;

        private ISupplierService _supplierService;

        public ProjectCategoryProductService(IProductService productService, ISupplierService supplierService)
        {
            this._productService = productService;

            this._supplierService = supplierService;
        }

        private ProjectCategoryProduct IncludeSupplier(ProjectCategoryProduct projectCategoryProduct)
        {
            projectCategoryProduct.Supplier = _supplierService.Get(projectCategoryProduct.GetSupplierId());
            return projectCategoryProduct;
        }

        private ProjectCategoryProduct IncludeProduct(ProjectCategoryProduct projectCategoryProduct)
        {
            projectCategoryProduct.Product = _productService.Get(projectCategoryProduct.GetProductId());
            return projectCategoryProduct;
        }

        public List<ProjectCategoryProduct> GetByProjectCategory(int projectCategoryId)
        {
            List<ProjectCategoryProduct> projectCategoryProducts = new List<ProjectCategoryProduct>();
            projectCategoryProducts = _projectCategoryProductRepository.GetByProjectCategory(projectCategoryId).ToListBLL();

            for (int i = 0; i < projectCategoryProducts.Count - 1; i++)
            {
                projectCategoryProducts[i] = IncludeProduct(IncludeSupplier(projectCategoryProducts[i]));
            }

            return projectCategoryProducts;
        }
    }
}
