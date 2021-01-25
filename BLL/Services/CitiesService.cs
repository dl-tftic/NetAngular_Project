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
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Cities IncludeCountry(Cities cities)
        {
            try
            {
                cities.Country = _countryService.Get(cities.GetCountryId());
                return cities;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private List<Cities> IncludeCountries(List<Cities> cities)
        {
            try
            {
                for (int i = 0; i < cities.Count - 1; i++)
                {
                    cities[i] = IncludeCountry(cities[i]);
                }

                return cities;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cities Get(int id)
        {
            try
            {
                // return _cityRepo.Get(id).ToBLL(_countryService);
                return _cities.Where(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Cities> GetByName(string name)
        {
            try
            {
                // return _cityRepo.GetByName(name).ToListBLL(_countryService);
                return _cities.Where(x => x.City.Contains(name)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Cities> GetByPostalCode(string postalCode)
        {
            try
            {
                // return _cityRepo.GetByPostalCode(postalCode).ToListBLL(_countryService);
                return _cities.Where(x => x.Code.Contains(postalCode)).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Cities> GetCityByCountry(int countryId)
        {
            try
            {
                // return _cityRepo.GetCityByCountry(countryId).ToListBLL(_countryService);
                return _cities.Where(x => x.Country.Id == countryId).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Cities> GetAll()
        {
            try
            {
                return _cities;
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
                return _cityRepo.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
