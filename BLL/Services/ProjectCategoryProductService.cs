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
            try
            {
                projectCategoryProduct.Supplier = _supplierService.Get(projectCategoryProduct.GetSupplierId());
                return projectCategoryProduct;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private ProjectCategoryProduct IncludeProduct(ProjectCategoryProduct projectCategoryProduct)
        {
            try
            {
                projectCategoryProduct.Product = _productService.Get(projectCategoryProduct.GetProductId());
                return projectCategoryProduct;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<ProjectCategoryProduct> GetByProjectCategory(int projectCategoryId)
        {
            try
            {
                List<ProjectCategoryProduct> projectCategoryProducts = new List<ProjectCategoryProduct>();
                projectCategoryProducts = _projectCategoryProductRepository.GetByProjectCategory(projectCategoryId).ToListBLL();

                for (int i = 0; i < projectCategoryProducts.Count - 1; i++)
                {
                    projectCategoryProducts[i] = IncludeProduct(IncludeSupplier(projectCategoryProducts[i]));
                }

                return projectCategoryProducts;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                return _projectCategoryProductRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
