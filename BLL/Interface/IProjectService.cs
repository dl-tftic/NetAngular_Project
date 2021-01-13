using BLL.Models;
using System.Collections.Generic;

namespace BLL.Interface
{
    public interface IProjectService
    {
        public Project Get(int id);

        public List<Project> GetByAccountId(int accountId);

        public List<Project> GetByName(string name);

    }
}