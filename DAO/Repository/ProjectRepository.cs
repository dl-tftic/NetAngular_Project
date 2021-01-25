using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class ProjectRepository : BaseRepository, IRepository<Project>
    {

        public ProjectRepository() : base("Project")
        {

        }

        public Project Get(int id)
        {

            try
            {
                return this.Get<Project>("GetProject", id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //Command cmd = new Command("GetProject", true);
            //cmd.AddParameter("id", id);
            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<Project>(cmd, (reader) =>
            //                                    new Project
            //                                    {
            //                                        Id = (int)reader["Id"],
            //                                        Name = (string)reader["Name"],
            //                                        Code = (string)this.GetValueOrNull(reader["Code"]),
            //                                        Description = (string)this.GetValueOrNull(reader["Description"]),
            //                                        CreateBy = (int)reader["CreateBy"],
            //                                        CreateDate = (DateTime)reader["CreateDate"],
            //                                        AddressId = (int)reader["AddressId"]
            //                                    }).Single();
        }

        public IEnumerable<Project> GetByAccountId(int accountId)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Project> GetByName(string name)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Project> GetAll()
        {
            try
            {
                return this.GetAll<Project>("GetProjectAll");

                //Command cmd = new Command("GetProjectAll", true);

                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Project>(cmd, (reader) => ToType<Project>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Project obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Project obj)
        {
            throw new NotImplementedException();
        }
    }
}
