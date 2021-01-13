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
            bll.Supplier bll = new bll.Supplier();

            bll.Id = dto.Id;
            bll.Name = dto.Name;
            bll.Description = dto.Description;
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }
    }
}
