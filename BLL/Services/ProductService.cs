using System;
using System.Collections.Generic;
using System.Text;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class ProductService : IProductService
    {

        private ProductRepository _productRepository = new ProductRepository();

        private IProductCategoryService _productCategoryService;

        public ProductService(IProductCategoryService productCategoryService)
        {
            this._productCategoryService = productCategoryService;
        }

        private Product IncludeCategories(Product product)
        {
            product.Categories = _productCategoryService.Get(product.Id);
            return product;
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id).ToBLL();
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().ToListBLL();
        }

        public List<Product> GetByManufacturer(string manufacturer)
        {
            return _productRepository.GetByManufacturer(manufacturer).ToListBLL();
        }

        public List<Product> GetByName(string name)
        {
            return _productRepository.GetByName(name).ToListBLL();
        }

        public List<Product> GetByProject(int projectCategoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByProjectCategory(int projectCategoryId)
        {
            return _productRepository.GetByProjectCategory(projectCategoryId).ToListBLL();
        }
    }
}
