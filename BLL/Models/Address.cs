using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int cityId)
        {
            this._cityId = cityId;
        }

        private int _cityId;

        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        #nullable enable
        public string? Box { get; set; }
        #nullable disable

        public Cities City { get; set; }
        
        public Country Country { get; set; }

        public int GetCityId()
        {
            return _cityId;
        }
    }
}
