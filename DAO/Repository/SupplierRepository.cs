using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class SupplierRepository : BaseRepository, IRepository<Supplier>
    {

        public SupplierRepository() : base("Supplier")
        {
            
        }

        //public Supplier Get(int id)
        //{
        //    Command cmd = new Command("GetSupplier", true);
        //    cmd.AddParameter("id", id);
        //    Connection conn = new Connection(this.connectionString);
        //    return conn.ExecuteReader<Supplier>(cmd, (reader) =>
        //                                        new Supplier
        //                                        {
        //                                            Id = (int)reader["Id"],
        //                                            Name = (string)reader["Name"],
        //                                            Description = (string)this.GetValueOrNull(reader["Description"]),
        //                                            AddressId = (int)reader["AddressId"],
        //                                            CreateBy = (int)reader["CreateBy"],
        //                                            CreateDate = (DateTime)reader["CreateDate"]
        //                                        }).Single();
        //}

        public Supplier Get(int id)
        {
            try
            {
                return this.Get<Supplier>("GetSupplier", id);

                //Command cmd = new Command("GetSupplier", true);
                //cmd.AddParameter("id", id);
                //Connection conn = new Connection(this.connectionString);
                //return conn.ExecuteReader<Supplier>(cmd, (reader) => ToType<Supplier>(reader)).Single();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IEnumerable<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Supplier obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Supplier obj)
        {
            throw new NotImplementedException();
        }
    }
}
