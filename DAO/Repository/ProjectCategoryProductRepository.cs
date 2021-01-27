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

        public int Insert(ProjectCategoryProduct projectCategoryProduct)
        {
            try
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();

                dico.Add("Code", projectCategoryProduct.Code);
                dico.Add("ProductId", projectCategoryProduct.ProductId);
                dico.Add("Project_CategoryId", projectCategoryProduct.Project_CategoryId);
                dico.Add("SupplierId", projectCategoryProduct.SupplierId);

                return this.Insert<ProjectCategoryProduct>("AddProjectCategoryProduct", dico);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Update(ProjectCategoryProduct obj)
        {
            throw new NotImplementedException();
        }
    }
}
