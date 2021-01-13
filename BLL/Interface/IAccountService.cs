using System;
using System.Collections.Generic;
using System.Text;
using BLL.Models;


namespace BLL.Interface
{
    public interface IAccountService
    {
        public Account Get(int id);
        public Account GetByLogin(string login);
    }
}
