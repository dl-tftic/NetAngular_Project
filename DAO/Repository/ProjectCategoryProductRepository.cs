using System;
using System.Collections.Generic;
using System.Text;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class ProjectCategoryProductRepository : RepositoryBase
    {
        public IEnumerable<ProjectCategoryProduct> GetByProjectCategory(int projectCategoryId)
        {
            Command cmd = new Command("GetProjectCategoryProduct", true);
            cmd.AddParameter("projectCategoryId", projectCategoryId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<ProjectCategoryProduct>(cmd, (reader) => ToType<ProjectCategoryProduct>(reader));
        }
    }
}
