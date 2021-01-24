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
            return _countryRepo.GetAll().ToListBLL();
        }

        public Country Get(int id)
        {
            return _countries.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Country> GetByName(string name)
        {
            return _countries.Where(x => x.Name.Contains(name)).ToList();
        }

        public List<Country> GetAll()
        {
            return _countries;
        }
    }
}
