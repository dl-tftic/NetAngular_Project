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
    public class AddressService : IAddressService
    {
        private AddressRepository _addressRepo = new AddressRepository();

        private ICitiesService _citiesService;

        public AddressService(ICitiesService citiesService)
        {
            try
            {
                this._citiesService = citiesService;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Address IncludeCity(Address address)
        {
            try
            {
                address.City = _citiesService.Get(address.GetCityId());
                return address;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Address Get(int id)
        {
            try
            {
                return IncludeCity(_addressRepo.Get(id).ToBLL());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Address address)
        {
            try
            {
                return _addressRepo.Insert(address.ToDTO());
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
                return _addressRepo.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
