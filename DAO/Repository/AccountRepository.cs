using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DTO.Models;
using Tools.Connection;
using DAO.Interface;

namespace DAO.Repository
{
    public class AccountRepository : BaseRepository, IRepository<Account>
    {

        public AccountRepository() : base("Account")
        {

        }

        public Account Get(int id)
        {
            try
            {
                return this.Get<Account>("GetAccount", id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetAccount", true);
            //cmd.AddParameter("id", id);
            //Connection conn = new Connection(this.connectionString);
            //return conn.ExecuteReader<Account>(cmd, (reader) =>
            //                                    new Account
            //                                    {
            //                                        Id = (int)reader["Id"],
            //                                        Login = (string)reader["Login"],
            //                                        Activate = (bool)reader["Activate"],
            //                                        LastName = (string)reader["LastName"],
            //                                        FirstName = (string)reader["FirstName"],
            //                                        RoleID = (int)reader["RoleID"],
            //                                        AddressId = (int)reader["AddressId"],
            //                                        CreateDate = (DateTime)reader["CreateDate"],
            //                                        CreateBy = (int)reader["CreateBy"]
            //                                    }).Single();
        }

        public IEnumerable<Account> GetAll()
        {
            try
            {
                return this.GetAll<Account>("GetAccountAll");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //Command cmd = new Command("GetAccountAll", true);

            //Connection conn = new Connection(this.connectionString);

            //return conn.ExecuteReader<Account>(cmd, (reader) => ToType<Account>(reader));
        }
        public Account GetByLogin(string login)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool CheckPassword(string login, string password)
        {
            try
            { 
            Command cmd = new Command("CheckAccountPassword", true);
            cmd.AddParameter("login", login);
            cmd.AddParameter("password", password);
            Connection conn = new Connection(this.connectionString);

            return (conn.ExecuteReader<int>(cmd, (reader) => (int)reader["Id"]).ToList().Count > 0) ? true : false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Account obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Account obj)
        {
            throw new NotImplementedException();
        }

    }
}
