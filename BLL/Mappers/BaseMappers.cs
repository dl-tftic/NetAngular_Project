using BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappers
{
    public static class BaseMappers
    {
        /// <summary>
        /// Allow to convert a Ienumerable DTO Class to a List of BLL Class
        /// </summary>
        /// <typeparam name="T">BLL Class</typeparam>
        /// <typeparam name="U">DTO Class</typeparam>
        /// <param name="dto">dto object</param>
        /// <param name="convertTo">function to convert DTO object to BLL object</param>
        /// <returns>List of Bll Class</returns>
        public static List<T> ToListBLL<T, U>(this IEnumerable<U> dto, Func<U, T> convertTo)
        {
            List<T> bll = new List<T>();
            
            foreach (U item in dto)
            {
                bll.Add(convertTo(item));
            }

            return bll;
        }
    }
}