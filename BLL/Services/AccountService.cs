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
            try
            {
                account.Role = _rolesService.Get(account.GetRoleId());
                return account;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
          
        }
        private Account IncludeAddress(Account account)
        {
            try
            {
                account.Address = _addressService.Get(account.GetAddressId());
                return account;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        private Account IncludeContactInfos(Account account)
        {
            try
            {
                account.ContactInfos = _contactInfoServices.GetByAccountId(account.Id);
                return account;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Account IncludeAll(Account account)
        {
            try
            {
                return IncludeRole(IncludeAddress(IncludeContactInfos(account)));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private List<Account> IncludeAllList(List<Account> accounts)
        {
            try
            {
                for (int i = 0; i < accounts.Count - 1; i++)
                {
                    accounts[i] = IncludeAll(accounts[i]);
                }

                return accounts;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Account Get(int id)
        {
            try
            {
                return IncludeAll(_accountRepository.Get(id).ToBLL());

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Account> GetAll()
        {
            try
            {
                return IncludeAllList(_accountRepository.GetAll().ToListBLL());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public Account GetByLogin(string login)
        {
            try
            {
                return IncludeAll(_accountRepository.GetByLogin(login).ToBLL());
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
                return _accountRepository.CheckPassword(login, password);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                return _accountRepository.DeleteById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Insert(Account account)
        {
            try
            {
                return _accountRepository.Insert(account.ToDTO());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
