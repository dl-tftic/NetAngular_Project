using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DAO.Repository
{
    public abstract class RepositoryBase
    {
        //protected string connectionString = @"Data Source=DESKTOP-MHV8JRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
        //protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=Project;Integrated Security=false;User Id=sa;";
        protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=Project;Integrated Security=false;User Id=project_user; Password=Abc1234mydb";
        
        // @"Data Source = 192.168.1.119; Initial Catalog = heroDb; User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;"

        protected Object GetValueOrNull(Object reader)
        {
            return (reader == DBNull.Value) ? null : reader;
        }

        protected T ToType<T>(System.Data.IDataReader reader) where T : new()
        {
            // Console.WriteLine(typeof(T).ToString() + " - " + reader.FieldCount); 
            try
            {
                T o = new T();

                Type type = o.GetType();
                PropertyInfo[] props = type.GetProperties();

                foreach (PropertyInfo prop in props)
                {
                    //Console.WriteLine(prop.Name + " - " + prop.PropertyType);
                    // Console.WriteLine(prop.Name);

                    if (this.GetValueOrNull(reader[prop.Name]) is null)
                    {
                        prop.SetValue(o, null);
                    }
                    else
                    {
                        prop.SetValue(o, Convert.ChangeType(this.GetValueOrNull(reader[prop.Name]), prop.PropertyType));
                    }
                }

                return o;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
