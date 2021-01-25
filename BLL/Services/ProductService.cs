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
            try
            {
                product.Categories = _productCategoryService.Get(product.Id);
                return product;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Product Get(int id)
        {
            try
            {
                return IncludeCategories(_productRepository.Get(id).ToBLL());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return _productRepository.GetAll().ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Product> GetByManufacturer(string manufacturer)
        {
            try
            {
                return _productRepository.GetByManufacturer(manufacturer).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Product> GetByName(string name)
        {
            try
            {
                return _productRepository.GetByName(name).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Product> GetByProject(int projectCategoryId)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Product> GetByProjectCategory(int projectCategoryId)
        {
            try
            {
                return _productRepository.GetByProjectCategory(projectCategoryId).ToListBLL();
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
                return _productRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
