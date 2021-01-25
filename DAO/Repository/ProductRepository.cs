using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class ProductRepository : BaseRepository, IRepository<Product>
    {

        public ProductRepository() : base("Product")
        {

        }
        public Product Get(int id)
        {
            try
            {
                return this.Get<Product>("GetProduct", id);

                //Command cmd = new Command("GetProduct", true);
                //cmd.AddParameter("id", id);
                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader)).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return this.GetAll<Product>("GetProductAll");

                //Command cmd = new Command("GetProductAll", true);

                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Product> GetByManufacturer(string manufacturer)
        {
            try
            {
                Command cmd = new Command("GetProductByManufacturer", true);
                cmd.AddParameter("manufacturer", manufacturer);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Product> GetByName(string name)
        {
            try
            {
                Command cmd = new Command("GetProductByName", true);
                cmd.AddParameter("name", name);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Product> GetByProjectCategory(int projectCategoryId)
        {
            try
            {
                Command cmd = new Command("GetProductByProjectCategory", true);
                cmd.AddParameter("projectCategoryId", projectCategoryId);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Product obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}

