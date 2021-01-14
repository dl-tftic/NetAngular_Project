using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class ProductRepository : RepositoryBase
    {
        public Product Get(int id)
        {
            Command cmd = new Command("GetProduct", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader)).Single();
        }

        public IEnumerable<Product> GetAll()
        {
            Command cmd = new Command("GetProductAll", true);
            
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
        }

        public IEnumerable<Product> GetByManufacturer(string manufacturer)
        {
            Command cmd = new Command("GetProductByManufacturer", true);
            cmd.AddParameter("manufacturer", manufacturer);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
        }

        public IEnumerable<Product> GetByName(string name)
        {
            Command cmd = new Command("GetProductByName", true);
            cmd.AddParameter("name", name);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
        }

        public IEnumerable<Product> GetByProjectCategory(int projectCategoryId)
        {
            Command cmd = new Command("GetProductByProjectCategory", true);
            cmd.AddParameter("projectCategoryId", projectCategoryId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Product>(cmd, (reader) => ToType<Product>(reader));
        }
    }
}
