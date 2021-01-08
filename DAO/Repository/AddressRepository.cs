using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class AddressRepository : RepositoryBase
    {
        public Address Get(int id)
        {
            Command cmd = new Command("GetAddress", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Address>(cmd, (reader) =>
                                                new Address
                                                {
                                                    Id = (int)reader["Id"],
                                                    Street = (string)reader["Street"],
                                                    Number = (string)reader["Number"],
                                                    //Box = (reader["Box"] == DBNull.Value) ? null : (string)reader["Box"],
                                                    Box = (string)this.GetValueOrNull(reader["Box"]),
                                                    CityId = (int)reader["CityId"]
                                                }).Single();
        }

        public int Insert(Address address)
        {
            return 0;
        }
    }
}
