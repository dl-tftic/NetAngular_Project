using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class SupplierRepository : RepositoryBase
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
            Command cmd = new Command("GetSupplier", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Supplier>(cmd, (reader) => ToType<Supplier>(reader)).Single();
        }
    }
}
