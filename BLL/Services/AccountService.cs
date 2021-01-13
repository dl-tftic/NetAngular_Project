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

        private IContactInfoService _contactInfoServices;

        public AccountService(  IAddressService addressService, 
                                IRolesService rolesService, 
                                IContactInfoService contactInfoService)
        {
            this._addressService = addressService;

            this._rolesService = rolesService;

            this._contactInfoServices = contactInfoService;
        }

        private Account IncludeRole(Account account)
        {
            account.Role = _rolesService.Get(account.GetRoleId());
            return account;
        }
        private Account IncludeAddress(Account account)
        {
            account.Address = _addressService.Get(account.GetAddressId());
            return account;
        }

        private Account IncludeContactInfos(Account account)
        {
            account.ContactInfos = _contactInfoServices.GetByAccountId(account.Id);
            return account;
        }

        private Account IncludeAll(Account account)
        {
            return IncludeRole(IncludeAddress(IncludeContactInfos(account)));
        }

        public Account Get(int id)
        {
            return IncludeAll(_accountRepository.Get(id).ToBLL());
        }

        public Account GetByLogin(string login)
        {
            return _accountRepository.GetByLogin(login).ToBLL();
        }
    }
}
