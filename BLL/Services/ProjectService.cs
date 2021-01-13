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

        public ProjectService(IAddressService addressService)
        {
            this._addressService = addressService;
        }

        private Project IncludeAddress(Project project)
        {
            project.Address = _addressService.Get(project.GetAddressId());
            return project;
        }

        public Project Get(int id)
        {
            return _projectRepository.Get(id).ToBLL();
        }

        public List<Project> GetByAccountId(int accountId)
        {
            return _projectRepository.GetByAccountId(accountId).ToListBLL(); ;
        }

        public List<Project> GetByName(string name)
        {
            return _projectRepository.GetByName(name).ToListBLL();
        }
    }
}
