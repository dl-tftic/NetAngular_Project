using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class ProductCategoryRepository : BaseRepository, IRepository<ProductCategory>
    {

        public ProductCategoryRepository() : base("ProductCategory")
        {

        }
        public IEnumerable<ProductCategory> Get(int productId)
        {
            try
            {
                return this.GetByMultiple<ProductCategory>("GetProductCategories", 
                                        new Dictionary<string, object>() { { "productId", productId } });

                //Command cmd = new Command("GetProductCategories", true);
                //cmd.AddParameter("productId", productId);
                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<ProductCategory>(cmd, (reader) => ToType<ProductCategory>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductCategory obj)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductCategory obj)
        {
            throw new NotImplementedException();
        }

        ProductCategory IRepository<ProductCategory>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
