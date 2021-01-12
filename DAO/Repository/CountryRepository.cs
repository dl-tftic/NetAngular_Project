using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class CountryRepository : RepositoryBase
    {
        public Country Get(int id)
        {
            Command cmd = new Command("GetCountry", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Country>(cmd, (reader) => toType<Country>(reader)).Single();
        }

        public IEnumerable<Country> GetByCode(string Iso)
        {
            Command cmd = new Command("GetCountryByCode", true);
            cmd.AddParameter("Iso", Iso);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Country>(cmd, (reader) => toType<Country>(reader));
        }

        public IEnumerable<Country> GetByName(string name)
        {
            Command cmd = new Command("GetCountryByName", true);
            cmd.AddParameter("name", name);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Country>(cmd, (reader) => toType<Country>(reader));
        }

        public IEnumerable<Country> GetAll()
        {
            Command cmd = new Command("GetCountryAll", true);
            
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Country>(cmd, (reader) => toType<Country>(reader));
        }
    }
}
