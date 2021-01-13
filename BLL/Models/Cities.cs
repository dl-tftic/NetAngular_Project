using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Cities
    {
        public Cities()
        {

        }

        public Cities(int countryId) : base()
        {
            this.countryIdCityId = countryId;
        }

        private int countryIdCityId;
        public int Id { get; set; }
        public Country Country { get; set; }
        public string Code { get; set; }
        public string City { get; set; }

        public int GetCountryId()
        {
            return countryIdCityId;
        }
    }
}
