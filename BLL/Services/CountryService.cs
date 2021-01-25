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
    public class CountryService : ICountryService
    {
        private CountryRepository _countryRepo = new CountryRepository();

        private List<Country> _countries;

        public CountryService()
        {
            _countries = Load();
        }

        private List<Country> Load()
        {
            try
            {
                return _countryRepo.GetAll().ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Country Get(int id)
        {
            try
            {
                return _countries.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Country> GetByName(string name)
        {
            try
            {
                return _countries.Where(x => x.Name.Contains(name)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Country> GetAll()
        {
            try
            {
                return _countries;
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
                return _countryRepo.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
