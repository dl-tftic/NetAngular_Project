using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Interface
{
    public interface IRepository<T>
    {
        public T Get(int id);

        public IEnumerable<T> GetAll();

        public int Insert(T obj);

        public int Update(T obj);

        // As DeleteById exist in baseRepository, 
        // it will be consider later a delete function in interface
        // public int Delete(int id);
    }
}
