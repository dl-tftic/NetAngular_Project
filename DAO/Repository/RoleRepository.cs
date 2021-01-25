using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class RoleRepository : BaseRepository, IRepository<Roles>
    {

        public RoleRepository() : base("Role")
        {

        }

        public Roles Get(int id)
        {
            try
            {
                return this.Get<Roles>("GetRole", id);

                //Command cmd = new Command("GetRole", true);
                //cmd.AddParameter("id", id);
                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Roles>(cmd, (reader) =>
                //                                    new Roles
                //                                    {
                //                                        Id = (int)reader["Id"],
                //                                        Role = (string)reader["Role"],
                //                                        Description = (string)reader["Description"],
                //                                    }).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Roles> GetAll()
        {
            try
            {
                return this.GetAll<Roles>("GetRoleAll");

                //Command cmd = new Command("GetRoleAll", true);

                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Roles>(cmd, (reader) => ToType<Roles>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Roles obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Roles obj)
        {
            throw new NotImplementedException();
        }
    }
}
