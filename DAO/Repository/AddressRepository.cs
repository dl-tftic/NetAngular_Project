using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class AddressRepository : BaseRepository, IRepository<Address>
    {

        public AddressRepository() : base ("Address")
        {

        }
        public Address Get(int id)
        {
            try
            {
                return this.Get<Address>("GetAddress", id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetAddress", true);
            //cmd.AddParameter("id", id);
            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<Address>(cmd, (reader) =>
            //                                    new Address
            //                                    {
            //                                        Id = (int)reader["Id"],
            //                                        Street = (string)reader["Street"],
            //                                        Number = (string)reader["Number"],
            //                                        Box = (string)this.GetValueOrNull(reader["Box"]),
            //                                        CityId = (int)reader["CityId"]
            //                                    }).Single();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
            // return this.GetAll<Address>("");
        }

        public int Insert(Address address)
        {
            try
            {
                Command cmd = new Command("AddAddress", true);
                cmd.AddParameter("Street", address.Street);
                cmd.AddParameter("Number", address.Number);
                cmd.AddParameter("Box", address.Box);
                cmd.AddParameter("CityId", address.CityId);

                Connection conn = new Connection(this.connectionString);

                return conn.ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Update(Address obj)
        {
            throw new NotImplementedException();
        }
    }
}
