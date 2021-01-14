using BLL.Models;
using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IFilesService
    {
        public Files Get(int id);

        public List<Files> GetByProductCategory(int productCategoryId);

        public int Insert(Files file);
    }
}