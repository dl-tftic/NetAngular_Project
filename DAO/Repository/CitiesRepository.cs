using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class CitiesRepository : BaseRepository, IRepository<Cities>
    {

        public CitiesRepository() : base("Cities")
        {

        }

        public Cities Get(int id)
        {
            try
            {
                return this.Get<Cities>("GetCity", id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetCity", true);
            //cmd.AddParameter("id", id);
            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<Cities>(cmd, (reader) =>
            //                                    new Cities
            //                                    {
            //                                        Id = (int)reader["Id"],
            //                                        City = (string)reader["City"],
            //                                        Code = (string)reader["Code"],
            //                                        CountryId = (int)reader["CountryId"]
            //                                    }).Single();
        }

        public IEnumerable<Cities> GetByName(string name)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Cities> GetByPostalCode(string postalCode)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Cities> GetCityByCountry(int countryId)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Cities> GetAll()
        {
            try
            {
                return this.GetAll<Cities>("GetCityAll");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetCityAll", true);

            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<Cities>(cmd, (reader) => ToType<Cities>(reader));
        }

        public int Insert(Cities obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Cities obj)
        {
            throw new NotImplementedException();
        }
    }
}
