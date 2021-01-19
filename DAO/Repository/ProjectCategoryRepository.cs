﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class ProjectCategoryRepository : RepositoryBase
    {

        public ProjectCategoryRepository() : base("ProjectCategory")
        {

        }

        public IEnumerable<ProjectCategory> Get(int projectId)
        {
            Command cmd = new Command("GetProjectCategories", true);
            cmd.AddParameter("projectId", projectId);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<ProjectCategory>(cmd, (reader) => ToType<ProjectCategory>(reader));
        }
    }
}
