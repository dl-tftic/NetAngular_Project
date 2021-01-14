using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface IProductService
    {
        public Product Get(int id);
        public List<Product> GetAll();
        public List<Product> GetByManufacturer(string manufacturer);
        public List<Product> GetByName(string name);
        public List<Product> GetByProject(int projectCategoryId);


    }
}
