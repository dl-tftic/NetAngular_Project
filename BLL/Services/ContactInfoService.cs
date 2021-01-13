using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interface;
using BLL.Models;
using DAO.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class ContactInfoService : IContactInfoService
    {
        private ContactInfoRepository _contactInfoRepository = new ContactInfoRepository();
        public ContactInfo Get(int id)
        {
            return _contactInfoRepository.Get(id).ToBLL();
        }
    }
}
