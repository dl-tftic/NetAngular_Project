using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class ProjectCategoryRepository : BaseRepository, IRepository<ProjectCategory>
    {

        public ProjectCategoryRepository() : base("ProjectCategory")
        {

        }

        public IEnumerable<ProjectCategory> Get(int projectId)
        {
            try
            {
                return this.GetByMultiple<ProjectCategory>("GetProjectCategories", 
                                                        new Dictionary<string, object>() { { "projectId", projectId } });
                //Command cmd = new Command("GetProjectCategories", true);
                //cmd.AddParameter("projectId", projectId);
                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<ProjectCategory>(cmd, (reader) => ToType<ProjectCategory>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<ProjectCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(ProjectCategory projectCategory)
        {
            try
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();

                dico.Add("ProjectId", projectCategory.ProjectId);
                dico.Add("CategoryId", projectCategory.CategoryId);
                dico.Add("ParentProjectCategoryId", projectCategory.ParentProjectCategoryId);

                return this.Insert<ProjectCategory>("AddProjectCategory", dico);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Update(ProjectCategory obj)
        {
            throw new NotImplementedException();
        }

        ProjectCategory IRepository<ProjectCategory>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
