using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface ICitiesService
    {
        Cities Get(int id);
        List<Cities> GetByName(string name);
        List<Cities> GetByPostalCode(string postalCode);
        List<Cities> GetCityByCountry(int countryId);
    }
}
