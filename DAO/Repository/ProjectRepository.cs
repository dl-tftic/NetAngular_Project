using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class ProjectRepository : RepositoryBase
    {

        public ProjectRepository() : base("Project")
        {

        }

        public Project Get(int id)
        {
            Command cmd = new Command("GetProject", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Project>(cmd, (reader) =>
                                                new Project
                                                {
                                                    Id = (int)reader["Id"],
                                                    Name = (string)reader["Name"],
                                                    Code = (string)this.GetValueOrNull(reader["Code"]),
                                                    Description = (string)this.GetValueOrNull(reader["Description"]),
                                                    CreateBy = (int)reader["CreateBy"],
                                                    CreateDate = (DateTime)reader["CreateDate"],
                                                    AddressId = (int)reader["AddressId"]
                                                }).Single();
        }

        public IEnumerable<Project> GetByAccountId(int accountId)
        {
            Command cmd = new Command("GetProjectByAccountId", true);
            cmd.AddParameter("accountId", accountId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Project>(cmd, (reader) =>
                                                new Project
                                                {
                                                    Id = (int)reader["Id"],
                                                    Name = (string)reader["Name"],
                                                    Code = (string)this.GetValueOrNull(reader["Code"]),
                                                    Description = (string)this.GetValueOrNull(reader["Description"]),
                                                    CreateBy = (int)reader["CreateBy"],
                                                    CreateDate = (DateTime)reader["CreateDate"],
                                                    AddressId = (int)reader["AddressId"]
                                                });
        }

        public IEnumerable<Project> GetByName(string name)
        {
            Command cmd = new Command("GetProjectByName", true);
            cmd.AddParameter("name", name);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Project>(cmd, (reader) =>
                                                new Project
                                                {
                                                    Id = (int)reader["Id"],
                                                    Name = (string)reader["Name"],
                                                    Code = (string)this.GetValueOrNull(reader["Code"]),
                                                    Description = (string)this.GetValueOrNull(reader["Description"]),
                                                    CreateBy = (int)reader["CreateBy"],
                                                    CreateDate = (DateTime)reader["CreateDate"],
                                                    AddressId = (int)reader["AddressId"]
                                                });
        }
    }
}
