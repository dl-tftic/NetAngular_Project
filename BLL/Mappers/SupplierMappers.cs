using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class SupplierMappers
    {
        public static bll.Supplier ToBLL(this dto.Supplier dto)
        {
            bll.Supplier bll = new bll.Supplier(dto.AddressId);

            bll.Id = dto.Id;
            bll.Name = dto.Name;
            bll.Description = dto.Description;
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }

        public static dto.Supplier ToDTO(this bll.Supplier bll)
        {
            dto.Supplier dto = new dto.Supplier();

            dto.Id = bll.Id;
            dto.Name = bll.Name;
            dto.Description = bll.Description;
            dto.CreateDate = bll.CreateDate;
            dto.CreateBy = bll.CreateBy;
            dto.AddressId = bll.Address.Id;

            return dto;
        }
    }
}
