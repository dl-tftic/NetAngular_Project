using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public bool Activate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int RoleID { get; set; }
        public int AddressId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
    }
}
