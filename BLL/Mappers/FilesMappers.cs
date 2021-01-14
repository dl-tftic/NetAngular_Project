using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class FilesMappers
    {
        public static bll.Files ToBLL(this dto.Files dto)
        {
            bll.Files bll = new bll.Files();

            bll.Id = dto.Id;
            bll.Name = dto.Name;
            bll.FileName = dto.FileName;
            bll.FileExension = dto.FileExension;
            bll.FileByte = dto.FileByte;
            bll.FileSize = dto.FileSize;
            bll.FileLinkId = dto.FileLinkId;
            bll.Description = dto.Description;
            bll.CreateDate = dto.CreateDate;
            bll.CreateBy = dto.CreateBy;

            return bll;
        }

        public static dto.Files ToDTO(this bll.Files bll)
        {
            dto.Files dto = new dto.Files();

            dto.Id = bll.Id;
            dto.Name = bll.Name;
            dto.FileName = bll.FileName;
            dto.FileExension = bll.FileExension;
            dto.FileByte = bll.FileByte;
            dto.FileSize = bll.FileSize;
            dto.FileLinkId = bll.FileLinkId;
            dto.Description = bll.Description;
            dto.CreateDate = bll.CreateDate;
            dto.CreateBy = bll.CreateBy;

            return dto;
        }

        public static List<bll.Files> ToListBLL(this IEnumerable<dto.Files> dto)
        {
            List<bll.Files> bll = new List<bll.Files>();

            foreach (dto.Files item in dto)
            {
                bll.Add(item.ToBLL());
            }

            return bll;
        }
    }
}
