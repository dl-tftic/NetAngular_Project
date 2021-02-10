using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class ContactInfoRepository : BaseRepository, IRepository<ContactInfo>
    {

        public ContactInfoRepository() : base("ContactInfo")
        {

        }

        public ContactInfo Get(int id)
        {
            try
            {
                return this.Get<ContactInfo>("GetContactInfo", id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetContactInfo", true);
            //cmd.AddParameter("id", id);
            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<ContactInfo>(cmd, (reader) => ToType<ContactInfo>(reader)).Single();
        }

        public IEnumerable<ContactInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactInfo> GetByAccountId(int accountId)
        {
            //Dictionary<string, object> dic = new Dictionary<string, object>();
            //dic.Add("AccountId", accountId);
            //GetByMultiple<ContactInfo>("", dic);
            try
            {
                Command cmd = new Command("GetContactInfoByAccountId", true);
                cmd.AddParameter("AccountId", accountId);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<ContactInfo>(cmd, (reader) => ToType<ContactInfo>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<ContactInfo> GetBySupplierId(int supplierId)
        {
            try
            {
                // Command cmd = new Command("GetContactInfoBySupplierId", true);
                Command cmd = new Command("GetSupplierContactInfo", true);
                //cmd.AddParameter("supplierId", supplierId);
                cmd.AddParameter("id", supplierId);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<ContactInfo>(cmd, (reader) => ToType<ContactInfo>(reader));
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
                Dictionary<string, object> dico = new Dictionary<string, object>();

                dico.Add("ContactType", contactInfo.ContactType);
                dico.Add("ContactInformation", contactInfo.ContactInformation);
                dico.Add("Description", contactInfo.Description);

                return this.Insert<Category>("AddCategory", dico);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Update(ContactInfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
