using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class CitiesRepository : RepositoryBase
    {
        public Cities Get(int id)
        {
            Command cmd = new Command("GetCity", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Cities>(cmd, (reader) =>
                                                new Cities
                                                {
                                                    Id = (int)reader["Id"],
                                                    City = (string)reader["City"],
                                                    Code = (string)reader["Code"],
                                                    CountryId = (int)reader["CountryId"]
                                                }).Single();
        }

        public IEnumerable<Cities> GetByName(string name)
        {
            Command cmd = new Command("GetCityByName", true);
            cmd.AddParameter("name", name);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Cities>(cmd, (reader) =>
                                                new Cities
                                                {
                                                    Id = (int)reader["Id"],
                                                    City = (string)reader["City"],
                                                    Code = (string)reader["Code"],
                                                    CountryId = (int)reader["CountryId"]
                                                });
        }

        public IEnumerable<Cities> GetByPostalCode(string postalCode)
        {
            Command cmd = new Command("GetCityByPostalCode", true);
            cmd.AddParameter("postalCode", postalCode);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Cities>(cmd, (reader) =>
                                                new Cities
                                                {
                                                    Id = (int)reader["Id"],
                                                    City = (string)reader["City"],
                                                    Code = (string)reader["Code"],
                                                    CountryId = (int)reader["CountryId"]
                                                });
        }

        public IEnumerable<Cities> GetCityByCountry(int countryId)
        {
            Command cmd = new Command("GetCityByCountry", true);
            cmd.AddParameter("CountryId", countryId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Cities>(cmd, (reader) =>
                                                new Cities
                                                {
                                                    Id = (int)reader["Id"],
                                                    City = (string)reader["City"],
                                                    Code = (string)reader["Code"],
                                                    CountryId = (int)reader["CountryId"]
                                                });
        }

        public IEnumerable<Cities> GetAll()
        {
            Command cmd = new Command("GetCityAll", true);
            
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Cities>(cmd, (reader) => toType<Cities>(reader));
        }
    }
}
