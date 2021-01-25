using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class CountryRepository : BaseRepository, IRepository<Country>
    {

        public CountryRepository() : base("Country")
        {

        }
        public Country Get(int id)
        {
            try
            {
                return this.Get<Country>("GetCountry", id);

                //Command cmd = new Command("GetCountry", true);
                //cmd.AddParameter("id", id);
                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Country>(cmd, (reader) => ToType<Country>(reader)).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Country> GetByCode(string Iso)
        {
            try
            {
                Command cmd = new Command("GetCountryByCode", true);
                cmd.AddParameter("Iso", Iso);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Country>(cmd, (reader) => ToType<Country>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Country> GetByName(string name)
        {
            try
            {
                Command cmd = new Command("GetCountryByName", true);
                cmd.AddParameter("name", name);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Country>(cmd, (reader) => ToType<Country>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Country> GetAll()
        {
            try
            {
                return this.GetAll<Country>("GetCountryAll");

                //Command cmd = new Command("GetCountryAll", true);

                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Country>(cmd, (reader) => ToType<Country>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Country obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Country obj)
        {
            throw new NotImplementedException();
        }
    }
}
