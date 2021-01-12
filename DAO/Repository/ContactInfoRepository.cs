using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class ContactInfoRepository : RepositoryBase
    {
        public ContactInfo Get(int id)
        {
            Command cmd = new Command("GetContactInfo", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<ContactInfo>(cmd, (reader) => toType<ContactInfo>(reader)).Single();
        }
    }
}
