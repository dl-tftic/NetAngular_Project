using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class RolesMappers
    {
        public static bll.Roles ToBLL(this dto.Roles dto)
        {
            bll.Roles bll = new bll.Roles();
            
            bll.Id = dto.Id;
            bll.Role = dto.Role;
            bll.Description = dto.Description;
            
            return bll;
        }

        public static dto.Roles ToDTO(this bll.Roles bll)
        {
            dto.Roles dto = new dto.Roles();

            dto.Id = bll.Id;
            dto.Role = bll.Role;
            dto.Description = bll.Description;

            return dto;
        }

        public static List<bll.Roles> ToListBLL(this IEnumerable<dto.Roles> dto)
        {
            List<bll.Roles> bll = new List<bll.Roles>();

            foreach (dto.Roles item in dto)
            {
                bll.Add(item.ToBLL());
            }

            return bll;
        }
    }
}
