using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class CountryMappers
    {
        public static bll.Country toBLL(this dto.Country dto)
        {
            bll.Country bll = new bll.Country();

            bll.Id = dto.Id;
            bll.Iso = dto.Iso;
            bll.iso3 = dto.iso3;
            bll.Name = dto.Name;
            bll.NumCode = dto.NumCode;
            bll.PhoneCode = dto.PhoneCode;

            return bll;
        }

        public static dto.Country toDTO(this bll.Country bll)
        {
            dto.Country dto = new dto.Country();

            dto.Id = bll.Id;
            dto.Iso = bll.Iso;
            dto.iso3 = bll.iso3;
            dto.Name = bll.Name;
            dto.NumCode = bll.NumCode;
            dto.PhoneCode = bll.PhoneCode;

            return dto;
        }

        public static List<bll.Country> toListBLL(this IEnumerable<dto.Country> dto)
        {
            List<bll.Country> countries = new List<bll.Country>();

            foreach (dto.Country item in dto)
            {
                countries.Add(item.toBLL());
            }

            return countries;
        }
    }
}
