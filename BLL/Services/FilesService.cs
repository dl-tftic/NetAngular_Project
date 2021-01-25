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
            try
            {
                return _filesRepository.Get(id).ToBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Files> GetByProductCategory(int productCategoryId)
        {
            try
            {
                return _filesRepository.GetByProductCategory(productCategoryId).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Files> GetByProjectCategory(int projectCategoryId)
        {
            try
            {
                return _filesRepository.GetByProjectCategory(projectCategoryId).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public byte[] Download(int id)
        {
            try
            {
                return _filesRepository.Download(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Files file)
        {
            try
            {
                return _filesRepository.Insert(file.ToDTO());
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
                return _filesRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
