using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;

namespace BLL.Interface
{
    public interface IAddressService
    {
        public Address Get(int id);
        public int Insert(Address address);

    }
}
