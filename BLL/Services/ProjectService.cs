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
            project.Address = _addressService.Get(project.GetAddressId());
            return project;
        }

        private Project IncludeProjectCategories(Project project)
        {
            project.Categories = _projectCategoryService.Get(project.Id);
            return project;
        }

        public Project Get(int id)
        {
            Project project = _projectRepository.Get(id).ToBLL();
            return IncludeAddress(IncludeProjectCategories(project));
        }

        public List<Project> GetByAccountId(int accountId)
        {
            return _projectRepository.GetByAccountId(accountId).ToListBLL(); ;
        }

        public List<Project> GetByName(string name)
        {
            return _projectRepository.GetByName(name).ToListBLL();
        }

        public List<Project> GetAll()
        {
            return _projectRepository.GetAll().ToListBLL();
        }
    }
}
