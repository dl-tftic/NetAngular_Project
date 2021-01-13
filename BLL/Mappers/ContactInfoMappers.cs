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
    }
}
