using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using System.Reflection;
using DAO.Interface;

namespace DAO.Repository
{

    public class CategoryRepository : BaseRepository, IRepository<Category>
    {

        public CategoryRepository(): base("Category")
        {
            
        }

        //public Category Get(int id)
        //{
        //    Command cmd = new Command("GetCategory", true);
        //    cmd.AddParameter("id", id);
        //    Connection conn = new Connection(this.connectionString);
        //    //object obj = toNew<Category>();
        //    return conn.ExecuteReader<Category>(cmd, (reader) =>
        //                                        new Category
        //                                        {
        //                                            Id = (int)reader["Id"],
        //                                            Name = (string)reader["Name"],
        //                                            Description = (string)this.GetValueOrNull(reader["Description"]),
        //                                            Type = (string)this.GetValueOrNull(reader["Type"]),
        //                                            CreateDate = (DateTime)reader["CreateDate"],
        //                                            CreateBy = (int)reader["CreateBy"]
        //                                        }).Single();
        //}

        public int Insert(Category category)
        {
            try
            {
                Command cmd = new Command("AddCategory", true);
                cmd.AddParameter("Name", category.Name);
                cmd.AddParameter("Description", category.Description);
                cmd.AddParameter("Type", category.Type);
                cmd.AddParameter("CreateBy", category.CreateBy);

                Connection conn = new Connection(this.connectionString);

                return conn.ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Category Get(int id)
        {
            try
            {
                return this.Get<Category>("GetCategory", id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetCategory", true);
            //cmd.AddParameter("id", id);
            //Connection conn = new Connection(this.connectionString);

            //return conn.ExecuteReader<Category>(cmd, (reader) => ToType<Category>(reader)).Single();
        }

        public IEnumerable<Category> GetByName(string name)
        {
            try
            {
                Command cmd = new Command("GetCategoryByName", true);
                cmd.AddParameter("name", name);
                Connection conn = new Connection(this.connectionString);

                return conn.ExecuteReader<Category>(cmd, (reader) => ToType<Category>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            try
            {
                return this.GetAll<Category>("GetCategoryAll");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetCategoryAll", true);

            //Connection conn = new Connection(this.connectionString);

            //return conn.ExecuteReader<Category>(cmd, (reader) => ToType<Category>(reader));
        }

        public int Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }

}
