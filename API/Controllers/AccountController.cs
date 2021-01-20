﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using BLL.Models;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
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
        public List<Account> GetAll()
        {
            return _accountService.GetAll();
        }

        [HttpGet("ById/{id}")]
        public Account GetById(int id)
        {
            return _accountService.Get(id);
        }

        [HttpGet("CheckPassword")]
        [Route("api/[controller]/CheckPassword")]
        public bool CheckPassword([FromBody] JObject body)
        {
            return _accountService.CheckPassword(body["login"].ToString(), body["password"].ToString());
        }

        [HttpGet("{login}")]
        public Account GetByLogin(string login)
        {
            return _accountService.GetByLogin(login);
        }
    }
}