using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;

namespace DAO.Repository
{
    public class AccountRepository : RepositoryBase
    {
        public Account Get(int id)
        {
            Command cmd = new Command("GetAccount", true);
            cmd.AddParameter("id", id);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Account>(cmd, (reader) =>
                                                new Account
                                                {
                                                    Id = (int)reader["Id"],
                                                    Login = (string)reader["Login"],
                                                    Activate = (bool)reader["Activate"],
                                                    LastName = (string)reader["LastName"],
                                                    FirstName = (string)reader["FirstName"],
                                                    RoleID = (int)reader["RoleID"],
                                                    AddressId = (int)reader["AddressId"],
                                                    CreateDate = (DateTime)reader["CreateDate"],
                                                    CreateBy = (int)reader["CreateBy"]
                                                }).Single();
        }

        public Account GetAccountByLogin(string login)
        {
            Command cmd = new Command("GetAccountByLogin", true);
            cmd.AddParameter("login", login);
            Connection conn = new Connection(this.connectionString);
            return conn.ExecuteReader<Account>(cmd, (reader) =>
                                                new Account
                                                {
                                                    Id = (int)reader["Id"],
                                                    Login = (string)reader["Login"],
                                                    Activate = (bool)reader["Activate"],
                                                    LastName = (string)reader["LastName"],
                                                    FirstName = (string)reader["FirstName"],
                                                    RoleID = (int)reader["RoleID"],
                                                    AddressId = (int)reader["AddressId"],
                                                    CreateDate = (DateTime)reader["CreateDate"],
                                                    CreateBy = (int)reader["CreateBy"]
                                                }).Single();
        }
    }
}
