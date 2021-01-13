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
    public class AddressService : IAddressService
    {
        private AddressRepository _addressRepo = new AddressRepository();

        private ICitiesService _citiesService;

        public AddressService(ICitiesService citiesService)
        {
            this._citiesService = citiesService;
        }

        public Address Get(int id)
        {
            return _addressRepo.Get(id).ToBLL(_citiesService);
        }

        public int Insert(Address address)
        {
            return _addressRepo.Insert(address.ToDTO());
        }
    }
}
