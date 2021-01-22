using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using BLL.Models;
using Newtonsoft.Json.Linq;
using API.Interface;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : Controller, Interface.IControllerInterface<Account>
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
        public IActionResult GetAll()
        {
            return Ok(_accountService.GetAll());
        }

        [HttpGet("ById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_accountService.Get(id));
        }

        [HttpGet("CheckPassword")]
        [Route("api/[controller]/CheckPassword")]
        public IActionResult CheckPassword([FromBody] JObject body)
        {
            return Ok(_accountService.CheckPassword(body["login"].ToString(), body["password"].ToString()));
        }

        [HttpGet("{login}")]
        public Account GetByLogin(string login)
        {
            return _accountService.GetByLogin(login);
        }

        public IActionResult Insert(Account t)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
