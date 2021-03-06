﻿using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;
using BLL.Interface;

namespace BLL.Mappers
{
    public static class CityMappers
    {
        //public static bll.Cities toBLL(this dto.Cities dto)
        //{
        //    bll.Cities bll = new bll.Cities();

        //    bll.Id = dto.Id;
        //    bll.City = dto.City;
        //    bll.Code = dto.Code;
        //    // To modify and user DI instead of loading DB each time.
        //    CountryService cs = new CountryService();
        //    bll.Country = cs.Get(dto.CountryId);

        //    return bll;
        //}

        public static bll.Cities ToBLL(this dto.Cities dto)
        {
            bll.Cities bll = new bll.Cities(dto.CountryId);

            bll.Id = dto.Id;
            bll.City = dto.City;
            bll.Code = dto.Code;
            //bll.Country = country.Get(dto.CountryId);

            return bll;
        }

        public static dto.Cities ToDTO(this bll.Cities bll)
        {
            dto.Cities dto = new dto.Cities();

            dto.Id = bll.Id;
            dto.City = bll.City;
            dto.Code = bll.Code;
            dto.CountryId = bll.Country.Id;

            return dto;
        }

        public static List<bll.Cities> ToListBLL(this IEnumerable<dto.Cities> dto)
        {
            List<bll.Cities> cities = new List<bll.Cities>();

            foreach (dto.Cities item in dto)
            {
                cities.Add(item.ToBLL());
            }

            return cities;
        }
    }
}
