using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;

namespace BLL.Services
{
    public class RolesService
    {
        private RoleRepository _roleRepo = new RoleRepository();

        private List<Roles> _roles;

        public RolesService()
        {
            _roles = GetAll();
        }

        private List<Roles> GetAll()
        {
            return _roleRepo.GetAll().toListBLL();
        }

        public Roles Get(int id)
        {
            try
            {
                Roles r = _roles.Where(x => x.Id == id).SingleOrDefault();

                if (r is null) throw new NullReferenceException("Roles can't be null");

                return r;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
