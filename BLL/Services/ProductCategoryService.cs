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
    public class ProductCategoryService : IProductCategoryService
    {
        private ProductCategoryRepository _productCategoryRepository = new ProductCategoryRepository();

        private ICategoryService _categoryService;

        private IFilesService _filesService;

        public ProductCategoryService(ICategoryService categoryService, IFilesService filesService)
        {
            this._categoryService = categoryService;

            this._filesService = filesService;
        }

        public List<ProductCategory> Get(int productId)
        {
            List<ProductCategory> productCategories = new List<ProductCategory>();

            IEnumerable<dto.ProductCategory> dto = _productCategoryRepository.Get(productId);

            foreach (dto.ProductCategory item in dto)
            {
                ProductCategory productCategory = new ProductCategory(_categoryService.Get(item.CategoryId));
                productCategory.Id = item.Id;
                productCategory.ParentCategoryTypeId = item.ParentCategoryProductId;

                productCategory.AddFiles(_filesService.GetByProductCategory(productCategory.Id));

                if (item.ParentCategoryProductId is null)
                {
                    productCategories.Add(productCategory);
                }
                else
                {
                    // IEnumerable<ProductCategory> props = productCategories.Where(x => x.Id == item.ParentCategoryProductId);
                    // AddSubCategories(props.ToList(), productCategory.ParentCategoryProductId);
                    // props.Single().AddChildProductCategory(productCategory);
                    AddSubCategories(productCategories, productCategory);
                }
            }

            return productCategories;
        }

        public void AddSubCategories(List<ProductCategory> productCategories, ProductCategory productCategory)
        {
            foreach (ProductCategory pc in productCategories)
            {
                if (pc.HasChildren())
                {
                    AddSubCategories(pc.SubCategories, productCategory);
                }
                else
                {
                    ProductCategory child = productCategories.Where(x => x.Id == productCategory.ParentCategoryTypeId).SingleOrDefault();

                    if (child is null) { }
                    else
                    {
                        child.AddChildTypeCategory(productCategory);
                        break;
                    }
                }
            }
        }
    }
}
