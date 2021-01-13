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
        public static bll.Account ToBLL(this dto.Account dto, IAddressService address, IRolesService roles)
        {
            bll.Account bll = new bll.Account();

            bll.Id = dto.Id;
            bll.Activate = dto.Activate;
            bll.Login = dto.Login;
            bll.FirstName = dto.FirstName;
            bll.LastName = dto.LastName;
            bll.Address = address.Get(dto.AddressId);
            bll.Role = roles.Get(dto.RoleID);
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }
    }
}
