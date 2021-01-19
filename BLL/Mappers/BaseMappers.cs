using BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappers
{
    public static class BaseMappers
    {

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