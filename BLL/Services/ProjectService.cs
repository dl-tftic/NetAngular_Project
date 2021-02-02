using System;
using System.Collections.Generic;
using System.Text;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class ProjectService : IProjectService
    {
        private ProjectRepository _projectRepository = new ProjectRepository();

        private IAddressService _addressService;

        private IProjectCategoryService _projectCategoryService;

        public ProjectService(IAddressService addressService, IProjectCategoryService projectCategoryService)
        {
            this._addressService = addressService;

            this._projectCategoryService = projectCategoryService;
        }

        private Project IncludeAddress(Project project)
        {
            try
            {
                project.Address = _addressService.Get(project.GetAddressId());
                return project;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Project IncludeProjectCategories(Project project)
        {
            try
            {
                project.Categories = _projectCategoryService.Get(project.Id);
                return project;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Project Get(int id)
        {
            try
            {
                Project project = _projectRepository.Get(id).ToBLL();
                return IncludeAddress(IncludeProjectCategories(project));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Project> GetByAccountId(int accountId)
        {
            try
            {
                return _projectRepository.GetByAccountId(accountId).ToListBLL(); ;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Project> GetByName(string name)
        {
            try
            {
                return _projectRepository.GetByName(name).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Project> GetAll()
        {
            try
            {
                return _projectRepository.GetAll().ToListBLL();
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
                return _projectRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Project project)
        {
            try
            {
                project.Address.Id = this._addressService.Insert(project.Address);
                return _projectRepository.Insert(project.ToDTO());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert (Project project, Address address)
        {
            try
            {
                project.Address.Id = this._addressService.Insert(address);

                return this.Insert(project);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
