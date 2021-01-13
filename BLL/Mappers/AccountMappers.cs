using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;
using BLL.Interface;

namespace BLL.Mappers
{
    public static class AccountMappers
    {
        public static bll.Account ToBLL(this dto.Account dto)
        {
            bll.Account bll = new bll.Account(dto.RoleID, dto.AddressId);

            bll.Id = dto.Id;
            bll.Activate = dto.Activate;
            bll.Login = dto.Login;
            bll.FirstName = dto.FirstName;
            bll.LastName = dto.LastName;
            //bll.Address = address.Get(dto.AddressId);
            //bll.Role = roles.Get(dto.RoleID);
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }

        public static dto.Account ToDTO(this bll.Account bll)
        {
            dto.Account dto = new dto.Account();

            dto.Id = bll.Id;
            dto.Activate = bll.Activate;
            dto.Login = bll.Login;
            dto.FirstName = bll.FirstName;
            dto.LastName = bll.LastName;
            dto.AddressId = bll.Address.Id;
            dto.RoleID = bll.Role.Id;
            dto.CreateDate = bll.CreateDate;
            dto.CreateBy = bll.CreateBy;

            return dto;
        }

    }
}
