using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using BLL.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private AccountService _accountService;

        public AccountController(IAddressService addressService, IRolesService rolesService, IContactInfoService contactInfoService)
        {
            _accountService = new AccountService(addressService, rolesService, contactInfoService);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome";
        }

        [HttpGet("ById/{id}")]
        public Account GetById(int id)
        {
            return _accountService.Get(id);
        }

        [HttpGet("{login}")]
        public Account GetByLogin(string login)
        {
            return _accountService.GetByLogin(login);
        }
    }
}
