using System;
using System.Collections.Generic;
using System.Text;
using dto = DTO.Models;
using bll = BLL.Models;

namespace BLL.Mappers
{
    public static class ProductCategoryMappers
    {
        public static bll.ProductCategory ToBLL(this dto.ProductCategory dto)
        {
            bll.ProductCategory bll = new bll.ProductCategory();

            bll.Id = dto.Id;
            

            return bll;
        }

        public static dto.ProductCategory ToDTO(this bll.ProductCategory bll)
        {
            dto.ProductCategory dto = new dto.ProductCategory();

            dto.Id = bll.Id;
            

            return dto;
        }

        public static bll.ProductCategory ToProductCategory(this dto.Category dto, bll.ProductCategory bll)
        {
            //bll.ProductCategory bll = new bll.ProductCategory(dto.Id);



            return bll;
        }
    }
}
