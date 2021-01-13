using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class ProjectMappers
    {
        public static bll.Project ToBLL(this dto.Project dto)
        {
            bll.Project bll = new bll.Project(dto.AddressId);

            bll.Id = dto.Id;
            bll.Code = dto.Code;
            bll.Name = dto.Name;
            bll.Description = dto.Description;
            bll.CreateBy = dto.CreateBy;
            bll.CreateDate = dto.CreateDate;

            return bll;
        }

        public static dto.Project ToDTO(this bll.Project bll)
        {
            dto.Project dto = new dto.Project();

            dto.Id = bll.Id;
            dto.Code = bll.Code;
            dto.Name = bll.Name;
            dto.Description = bll.Description;
            dto.CreateBy = bll.CreateBy;
            dto.CreateDate = bll.CreateDate;
            dto.AddressId = bll.Address.Id;

            return dto;
        }

        public static List<bll.Project> ToListBLL(this IEnumerable<dto.Project> dto)
        {
            List<bll.Project> exportBll = new List<bll.Project>();

            foreach (dto.Project item in dto)
            {
                exportBll.Add(item.ToBLL());
            }

            return exportBll;
        }
    }
}