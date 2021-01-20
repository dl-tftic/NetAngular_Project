using System;
using System.Collections.Generic;
using System.Text;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();
        public Category Get(int id)
        {
            return _categoryRepository.Get(id).ToBLL();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll().ToListBLL();
        }

        public List<Category> GetByName(string name)
        {
            return _categoryRepository.GetByName(name).ToListBLL();
        }

        public int Insert(Category category)
        {
            return _categoryRepository.Insert(category.ToDTO());
        }

        public int Delete(int id)
        {
            return _categoryRepository.DeleteById(id);
        }
    }
}
