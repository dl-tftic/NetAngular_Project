using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class ContactInfoMappers
    {
        public static bll.ContactInfo ToBLL(this dto.ContactInfo dto)
        {
            bll.ContactInfo bll = new bll.ContactInfo();

            bll.Id = dto.Id;
            bll.ContactType = dto.ContactType;
            bll.ContactInformation = dto.ContactInformation;
            bll.Description = dto.Description;

            return bll;
        }

        public static dto.ContactInfo ToDTO(this bll.ContactInfo bll)
        {
            dto.ContactInfo dto = new dto.ContactInfo();

            dto.Id = bll.Id;
            dto.ContactType = bll.ContactType;
            dto.ContactInformation = bll.ContactInformation;
            dto.Description = bll.Description;

            return dto;
        }

        public static List<bll.ContactInfo> ToListBLL(this IEnumerable<dto.ContactInfo> dto)
        {
            List<bll.ContactInfo> contactInfos = new List<bll.ContactInfo>();

            foreach (dto.ContactInfo item in dto)
            {
                contactInfos.Add(item.ToBLL());
            }

            return contactInfos;
        }

        //public static List<T> ToListMappers<T,U>(this IEnumerable<U> us)
        //{
        //    List<T> newVar = new List<T>();

        //    foreach (U item in us)
        //    {
        //        newVar.Add(item);
        //    }

        //    return newVar;
        //}
    }
}
