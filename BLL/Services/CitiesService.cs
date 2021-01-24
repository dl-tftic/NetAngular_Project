using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAO.Repository;
using dto = DTO.Models;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;


namespace BLL.Services
{
    public class CitiesService : ICitiesService
    {
        private CitiesRepository _cityRepo = new CitiesRepository();

        private ICountryService _countryService;

        private List<Cities> _cities;

        public CitiesService(ICountryService countryService)
        {
            this._countryService = countryService;
            this._cities = Load();
        }

        private List<Cities> Load()
        {
            IEnumerable<dto.Cities> dtoCities = _cityRepo.GetAll();

            List<Cities> cities = new List<Cities>();

            foreach (dto.Cities item in dtoCities)
            {
                Cities city = item.ToBLL();
                city.Country = _countryService.Get(item.CountryId);
                cities.Add(city);
            }

            return cities;
        }

        private Cities IncludeCountry(Cities cities)
        {
            cities.Country = _countryService.Get(cities.GetCountryId());
            return cities;
        }

        private List<Cities> IncludeCountries(List<Cities> cities)
        {
            for (int i = 0; i < cities.Count - 1; i++)
            {
                cities[i] = IncludeCountry(cities[i]);
            }

            return cities;
        }

        public Cities Get(int id)
        {
            // return _cityRepo.Get(id).ToBLL(_countryService);
            return _cities.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Cities> GetByName(string name)
        {
            // return _cityRepo.GetByName(name).ToListBLL(_countryService);
            return _cities.Where(x => x.City.Contains(name)).ToList();
        }

        public List<Cities> GetByPostalCode(string postalCode)
        {
            // return _cityRepo.GetByPostalCode(postalCode).ToListBLL(_countryService);
            return _cities.Where(x => x.Code.Contains(postalCode)).ToList();
        }

        public List<Cities> GetCityByCountry(int countryId)
        {
            // return _cityRepo.GetCityByCountry(countryId).ToListBLL(_countryService);
            return _cities.Where(x => x.Country.Id == countryId).ToList();

        }

        public List<Cities> GetAll()
        {
            return _cities;
        }

    }
}
