﻿using System;
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
            return conn.ExecuteReader<ContactInfo>(cmd, (reader) => ToType<ContactInfo>(reader)).Single();
        }

        public IEnumerable<ContactInfo> GetByAccountId(int accountId)
        {
            Command cmd = new Command("GetContactInfoByAccountId", true);
            cmd.AddParameter("AccountId", accountId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<ContactInfo>(cmd, (reader) => ToType<ContactInfo>(reader));
        }
    }
}
