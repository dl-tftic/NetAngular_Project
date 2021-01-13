using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;
using BLL.Interface;

namespace BLL.Mappers
{
    public static class AddressMappers
    {
        public static bll.Address ToBLL(this dto.Address dto, ICitiesService cities)
        {
            bll.Address bll = new bll.Address();

            bll.Id = dto.Id;
            bll.Street = dto.Street;
            bll.Number = dto.Number;
            bll.Box = dto.Box;
            bll.City = cities.Get(dto.CityId);

            return bll;
        }

        public static dto.Address ToDTO(this bll.Address bll)
        {
            dto.Address dto = new dto.Address();

            dto.Id = bll.Id;
            dto.Street = bll.Street;
            dto.Number = bll.Number;
            dto.Box = bll.Box;
            dto.CityId = bll.City.Id;

            return dto;
        }
    }
}
