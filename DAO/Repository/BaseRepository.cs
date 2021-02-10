using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Tools.Connection;
using System.Data;
using System.Linq;


namespace DAO.Repository
{
    public abstract class BaseRepository
    {
        protected string connectionString = @"Data Source=DESKTOP-MHV8JRA\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";

        //protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=Project;Integrated Security=false;User Id=project_user; Password=Abc1234mydb";

        //protected string connectionString = @"Data Source=192.168.1.119;Initial Catalog=Project;Integrated Security=false;User Id=sa;";
        // @"Data Source = 192.168.1.119; Initial Catalog = heroDb; User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;"

        protected string tableName;

        /// <summary>
        /// 
        /// </summary>
        public BaseRepository()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName">Name of the db table link to the repository</param>
        public BaseRepository(string tableName)
        {
            this.tableName = tableName;
        }

        /// <summary>
        /// Convert to null if the value is dbNull
        /// </summary>
        /// <param name="reader">IDataReader from SqlCommand</param>
        /// <returns>The "field" with original value or null instead of dbNull</returns>
        protected Object GetValueOrNull(Object reader)
        {
            return (reader == DBNull.Value) ? null : reader;
        }

        /// <summary>
        /// Allow to mapp automatically object from DB to Class
        /// </summary>
        /// <typeparam name="T">Class wanted to convert To</typeparam>
        /// <param name="reader">Date From</param>
        /// <returns>T class object</returns>
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

        
        /// <summary>
        /// Allow to verify if db information has a specify column name
        /// </summary>
        /// <param name="dr">IDataReader from db</param>
        /// <param name="columnName">Column name</param>
        /// <returns>Boolean</returns>
        protected bool HasColumn(System.Data.IDataReader dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Allow to insert a row in db based on store procedure name and object
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="spName">store procedure name</param>
        /// <param name="par">dictionnary containing param name and value</param>
        /// <returns>id of the row inserted or 0 if issue</returns>
        protected int Insert<T>(string spName, Dictionary<string, object> par)
        {
            try
            {
                Command cmd = new Command(spName, true);

                foreach (var item in par)
                {
                    cmd.AddParameter(item.Key, item.Value);
                }

                Connection conn = new Connection(this.connectionString);

                return conn.ExecuteNonQuery(cmd);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        /// <summary>
        /// Allow to retrieve an instance of object T from db
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="spName">Name of the store procedure to call</param>
        /// <param name="id">id of the row in db</param>
        /// <returns></returns>
        protected T Get<T>(string spName ,int id) where T: new()
        {
            try
            {
                Command cmd = new Command(spName, true);
                cmd.AddParameter("id", id);
                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<T>(cmd, (reader) => ToType<T>(reader)).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        protected T GetBySingle<T>(string spName, Dictionary<string, object> par) where T : new()
        {
            try
            {
                // Single instead of First, an error must be return if there is more than 1 !
                return GetByMultiple<T>(spName, par).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command(spName, true);

            //foreach (var item in par)
            //{
            //    cmd.AddParameter(item.Key, item.Value);
            //}

            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<T>(cmd, (reader) => ToType<T>(reader)).Single();
        }

        protected IEnumerable<T> GetByMultiple<T>(string spName, Dictionary<string, object> par) where T : new()
        {
            try 
            { 
                Command cmd = new Command(spName, true);

                foreach (var item in par)
                {
                    cmd.AddParameter(item.Key, item.Value);
                }

                Connection conn = new Connection(this.connectionString);
                return conn.ExecuteReader<T>(cmd, (reader) => ToType<T>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
}

        /// <summary>
        /// Allow to retrieve some instance of object T from db
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="spName">Name of the store procedure to call</param>
        /// <returns></returns>
        protected IEnumerable<T> GetAll<T>(string spName) where T : new()
        {
            try
            {
                Command cmd = new Command(spName, true);

                Connection conn = new Connection(this.connectionString);

                return conn.ExecuteReader<T>(cmd, (reader) => ToType<T>(reader));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Allow to delete a row in db by id and table name. 
        /// This is a generic function and could not work for all tables in db
        /// </summary>
        /// <param name="id">id of row in db</param>
        /// <returns>int : 1 for row delete or 0 ir not</returns>
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

        /// <summary>
        /// Allow to delete a row in db by id and table name. 
        /// This is a generic function and could not work for all tables in db
        /// </summary>
        /// <param name="tableName">db table name</param>
        /// <param name="id">id of row in db</param>
        /// <returns>int : 1 for row delete or 0 ir not</returns>
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
                string msg = string.Concat("Table: " + tableName
                                            , " id: " + id.ToString()
                                            , Environment.NewLine
                                            , " " + e.Message
                                            );

                throw new Exception(msg);
            }
        }
    }
}
