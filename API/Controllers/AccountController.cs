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
 

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_accountService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_accountService.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //[HttpGet("CheckPassword")]
        //[Route("api/[controller]/CheckPassword")]
        public IActionResult CheckPassword([FromBody] JObject body)
        {
            return Ok(_accountService.CheckPassword(body["login"].ToString(), body["password"].ToString()));
        }

        [HttpGet("{login}")]
        public IActionResult GetByLogin(string login)
        {
            try
            {
                return Ok(_accountService.GetByLogin(login));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Insert(Account account)
        {
            try
            {
                return Ok(_accountService.Insert(account));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_accountService.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(Account t)
        {
            throw new NotImplementedException();
        }
    }
}
