using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class ProductCategoryRepository : RepositoryBase
    {
        public IEnumerable<ProductCategory> Get(int productId)
        {
            Command cmd = new Command("GetProductCategories", true);
            cmd.AddParameter("productId", productId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<ProductCategory>(cmd, (reader) => ToType<ProductCategory>(reader));
        }
    }
}
