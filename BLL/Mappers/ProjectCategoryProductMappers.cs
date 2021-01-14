using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class ProjectCategoryProductMappers
    {
        public static bll.ProjectCategoryProduct ToBLL(this dto.ProjectCategoryProduct dto)
        {
            bll.ProjectCategoryProduct bll = new bll.ProjectCategoryProduct(dto.ProductId, dto.SupplierId);

            bll.Project_CategoryId = dto.Project_CategoryId;
            bll.Code = dto.Code;

            return bll;
        }

        public static dto.ProjectCategoryProduct ToDTO(this bll.ProjectCategoryProduct bll)
        {
            dto.ProjectCategoryProduct dto = new dto.ProjectCategoryProduct();

            dto.Project_CategoryId = bll.Project_CategoryId;
            dto.Code = bll.Code;
            dto.SupplierId = bll.Supplier.Id;
            dto.ProductId = bll.Product.Id;

            return dto;
        }

        public static List<bll.ProjectCategoryProduct> ToListBLL(this IEnumerable<dto.ProjectCategoryProduct> dto)
        {
            List<bll.ProjectCategoryProduct> categories = new List<bll.ProjectCategoryProduct>();

            foreach (dto.ProjectCategoryProduct item in dto)
            {
                categories.Add(item.ToBLL());
            }

            return categories;
        }
    }
}
