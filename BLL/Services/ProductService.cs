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

        //private pro

        private Product IncludeCategories(Product product)
        {
            //product.Categories =
            return product;
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id).ToBLL();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByManufacturer(string manufacturer)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByProject(int projectCategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
