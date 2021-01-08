using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Repository
{
    public abstract class RepositoryBase
    {
        protected string connectionString = @"Data Source=DESKTOP-MHV8JRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
        //protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=heroDb;Integrated Security=false;User Id=heroDb;Password=abc123;";
        // @"Data Source = 192.168.1.119; Initial Catalog = heroDb; User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;"

        protected Object GetValueOrNull(Object reader)
        {
            return (reader == DBNull.Value) ? null : reader;
        }
    }
}
