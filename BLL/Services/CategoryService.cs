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
            try
            {
                return _categoryRepository.Get(id).ToBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                return _categoryRepository.GetAll().ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Category> GetByName(string name)
        {
            try
            {
                return _categoryRepository.GetByName(name).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Category category)
        {
            try
            {
                return _categoryRepository.Insert(category.ToDTO());
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
                return _categoryRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
