using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class ProductMappers
    {
        public static bll.Product ToBLL(this dto.Product dto)
        {
            bll.Product bll = new bll.Product();

            bll.Id = dto.Id;
            bll.Name = dto.Name;
            bll.Code = dto.Code;
            bll.Manufacturer = dto.Manufacturer;
            bll.Model = dto.Model;
            bll.Revision = dto.Revision;
            //bll.Categories = dto.;
            bll.Description = dto.Description;
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }

        public static dto.Product ToDTO(this bll.Product bll)
        {
            dto.Product dto = new dto.Product();

            dto.Id = bll.Id;
            dto.Name = bll.Name;
            dto.Code = bll.Code;
            dto.Manufacturer = bll.Manufacturer;
            dto.Model = bll.Model;
            dto.Revision = bll.Revision;
            dto.Description = bll.Description;
            dto.CreateDate = bll.CreateDate;
            dto.CreateBy = bll.CreateBy;

            return dto;
        }

        public static List<bll.Product> ToListBLL(this IEnumerable<dto.Product> dto)
        {
            List<bll.Product> bll = new List<bll.Product>();

            foreach (dto.Product item in dto)
            {
                bll.Add(item.ToBLL());
            }

            return bll;
        }

    }
}
