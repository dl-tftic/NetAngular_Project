using System;
using System.Collections.Generic;
using BLL.Models;

namespace BLL.Models
{
    public class Supplier
    {

        public Supplier()
        {
            this._addressId = -1;
        }

        public Supplier(int addressId)
        {
            this._addressId = addressId;
        }

        private int _addressId;

        public int Id { get; set; }
        public string Name { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable
        public Address Address { get; set; }

        public List<ContactInfo> ContactInfos { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }

        public int GetAddressId()
        {
            return _addressId;
        }
        
    }
}