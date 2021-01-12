using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;

namespace BLL.Services
{
    public class CountryService
    {
        private CountryRepository _countryRepo = new CountryRepository();

        private List<Country> _countries;

        public CountryService()
        {
            _countries = GetAll();
        }

        private List<Country> GetAll()
        {         
            return _countryRepo.GetAll().toListBLL();
        }

        public Country Get(int id)
        {
            return _countries.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Country> GetByName(string name)
        {
            return _countries.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
