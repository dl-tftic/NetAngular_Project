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
            try
            {
                return _contactInfoRepository.Get(id).ToBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<ContactInfo> GetByAccountId(int id)
        {
            try
            {
                return _contactInfoRepository.GetByAccountId(id).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<ContactInfo> GetBySupplierId(int supplierId)
        {
            try
            {
                return _contactInfoRepository.GetBySupplierId(supplierId).ToListBLL();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                // ContactInfo doesn't have any idea so, it will be necessary 
                // to have both field of primary key
                // return _contactInfoRepository.DeleteById(id);
                throw new Exception(id.ToString());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(ContactInfo contactInfo)
        {
            try
            {
                return _contactInfoRepository.Insert(contactInfo.ToDTO());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
