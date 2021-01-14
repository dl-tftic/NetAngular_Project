using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class CategoryMappers
    {
        public static bll.Category ToBLL(this dto.Category dto)
        {
            bll.Category bll = new bll.Category();

            bll.Id = dto.Id;
            bll.Name = dto.Name;            
            bll.Type = dto.Type;
            bll.Description = dto.Description;
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }

        public static dto.Category ToDTO(this bll.Category bll)
        {
            dto.Category dto = new dto.Category();

            dto.Id = bll.Id;
            dto.Name = bll.Name;
            dto.Type = bll.Type;
            dto.Description = bll.Description;
            dto.CreateDate = bll.CreateDate;
            dto.CreateBy = bll.CreateBy;

            return dto;
        }

        public static List<bll.Category> ToListBLL(this IEnumerable<dto.Category> dto)
        {
            List<bll.Category> categories = new List<bll.Category>();

            foreach (dto.Category item in dto)
            {
                categories.Add(item.ToBLL());
            }

            return categories;
        }
    }
}
