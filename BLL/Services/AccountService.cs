using System;
using System.Collections.Generic;
using System.Text;
using DAO.Repository;
using BLL.Models;
using BLL.Mappers;
using BLL.Interface;

namespace BLL.Services
{
    public class AccountService : IAccountService
    {
        private AccountRepository _accountRepository = new AccountRepository();

        private IAddressService _addressService;

        private IRolesService _rolesService;

        public AccountService(IAddressService addressService, IRolesService rolesService)
        {
            this._addressService = addressService;

            this._rolesService = rolesService;

        }

        public Account Get(int id)
        {
            return _accountRepository.Get(id).ToBLL(_addressService, _rolesService);
        }

        public Account GetByLogin(string login)
        {
            return _accountRepository.GetByLogin(login).ToBLL(_addressService, _rolesService);
        }
    }
}
