using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class FilesService : IFilesService
    {
        private FilesRepository _filesRepository = new FilesRepository();

        public Files Get(int id)
        {
            return _filesRepository.Get(id).ToBLL();
        }

        public List<Files> GetByProductCategory(int productCategoryId)
        {
            return _filesRepository.GetByProductCategory(productCategoryId).ToListBLL();
        }

        public int Insert(Files file)
        {
            return _filesRepository.Insert(file.ToDTO());
        }
    }
}
