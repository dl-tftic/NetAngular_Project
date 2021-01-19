using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class RoleRepository : RepositoryBase
    {

        public RoleRepository() : base("Role")
        {

        }

        public Roles Get(int id)
        {
            Command cmd = new Command("GetRole", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Roles>(cmd, (reader) =>
                                                new Roles
                                                {
                                                    Id = (int)reader["Id"],
                                                    Role = (string)reader["Role"],
                                                    Description = (string)reader["Description"],
                                                }).Single();
        }

        public IEnumerable<Roles> GetAll()
        {
            Command cmd = new Command("GetRoleAll", true);
            
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Roles>(cmd, (reader) => ToType<Roles>(reader));
        }
    }
}
