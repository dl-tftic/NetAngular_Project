﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class RolesService : IRolesService
    {
        private RoleRepository _roleRepo = new RoleRepository();

        private List<Roles> _roles;

        public RolesService()
        {
            _roles = GetAllRoles();
        }

        private List<Roles> GetAllRoles()
        {
            try
            {
                return _roleRepo.GetAll().ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

        public List<Roles> GetAll()
        {
            try
            {
                return _roles;
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
                return _roleRepo.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
