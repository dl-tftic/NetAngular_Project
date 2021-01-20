using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class Account
    {
        public Account()
        {

        }

        public Account(int roleId, int addressId)
        {
            this._roleId = roleId;
            this._addressId = addressId;
        }

        private int _roleId;
        private int _addressId;

        public int Id { get; set; }
        public string Login { get; set; }
        public bool Activate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        // public string Password { get; set; }
        // public string Salt { get; set; }
        public Roles Role { get; set; }
        public Address Address { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }

        public int GetRoleId()
        {
            return _roleId;
        }
        public int GetAddressId()
        {
            return _addressId;
        }
    }
}
