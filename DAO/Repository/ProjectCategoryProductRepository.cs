using System;
using System.Collections.Generic;
using System.Text;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class ProjectCategoryProductRepository : BaseRepository, IRepository<ProjectCategoryProduct>
    {
        public ProjectCategoryProductRepository(): base("ProjectCategoryProduct")
        {
                
        }

        public ProjectCategoryProduct Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectCategoryProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectCategoryProduct> GetByProjectCategory(int projectCategoryId)
        {
            try
            {
                Command cmd = new Command("GetProjectCategoryProduct", true);
                cmd.AddParameter("projectCategoryId", projectCategoryId);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<ProjectCategoryProduct>(cmd, (reader) => ToType<ProjectCategoryProduct>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(ProjectCategoryProduct obj)
        {
            throw new NotImplementedException();
        }

        public int Update(ProjectCategoryProduct obj)
        {
            throw new NotImplementedException();
        }
    }
}
