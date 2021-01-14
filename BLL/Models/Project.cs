using System;
using System.Collections.Generic;
using System.Text;
using BLL.Mappers;

namespace BLL.Models
{
    public class Project
    {
        public Project()
        {
            this._addressId = -1;
        }

        public Project(int addressId)
        {
            this._addressId = addressId;
        }

        //public Project(DTO.Models.Project project)
        //{
        //    this = project.ToBLL();
        //}

        private int _addressId;

        public int Id { get; set; }
        public string Name { get; set; }

#nullable enable
        public string? Code { get; set; }
        public string? Description { get; set; }
#nullable disable

        public DateTime CreateDate { get; set; }
        public int CreateBy { get; set; }
        public Address Address { get; set; }

        public List<ProjectCategory> Categories { get; set; }

        public int GetAddressId()
        {
            return _addressId;
        }
    }
}
