using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Tools.Connection;
using System.Data;

namespace DAO.Repository
{
    public abstract class RepositoryBase
    {
        //protected string connectionString = @"Data Source=DESKTOP-MHV8JRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
        //protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=Project;Integrated Security=false;User Id=sa;";
        protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=Project;Integrated Security=false;User Id=project_user; Password=Abc1234mydb";

        // @"Data Source = 192.168.1.119; Initial Catalog = heroDb; User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;"

        protected string tableName;

        public RepositoryBase()
        {

        }

        public RepositoryBase(string tableName)
        {
            this.tableName = tableName;
        }

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

                    if (HasColumn(reader, prop.Name))
                    {
                        if (this.GetValueOrNull(reader[prop.Name]) is null)
                        {
                            prop.SetValue(o, null);
                        }
                        else
                        {
                            prop.SetValue(o, Convert.ChangeType(this.GetValueOrNull(reader[prop.Name]), Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType));
                        }
                    }
                }

                return o;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        
        protected bool HasColumn(System.Data.IDataReader dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
        

        protected int DeleteById(string tableName, int id)
        {
            try
            {
                Command cmd = new Command("DeleteById", true);
                cmd.AddParameter("tableName", tableName);
                cmd.AddParameter("id", id);

                Connection conn = new Connection(this.connectionString);

                return conn.ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int DeleteById(int id)
        {
            try
            {
                return DeleteById(this.tableName, id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
