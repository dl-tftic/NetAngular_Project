using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface ICategoryService
    {
        public Category Get(int id);

        public int Insert(Category category);
        public List<Category> GetByName(string name);
        public List<Category> GetAll();
    }
}
