using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface ICountryService
    {
        public Country Get(int id);

        public List<Country> GetByName(string name);

        //private List<Country> GetAll();

    }
}
