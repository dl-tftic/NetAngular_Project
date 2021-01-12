using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;

namespace BLL.Services
{
    public class CitiesService
    {
        private CitiesRepository _cityRepo = new CitiesRepository();

        private CountryService _countryService = new CountryService();

        private List<Cities> _cities;

        public CitiesService()
        {
            _cities = GetAll();
        }

        private List<Cities> GetAll()
        {
            return _cityRepo.GetAll().toListBLL();
        }
    }
}
