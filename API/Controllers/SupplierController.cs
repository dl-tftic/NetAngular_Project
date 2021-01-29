﻿using API.Interface;
using BLL.Interface;
using BLL.Models;
using BLL.Services;
using DAO.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierController : Controller, IControllerInterface<Supplier>
    {
        private SupplierService _supplierService;

        public SupplierController(IAddressService addressService, IContactInfoService contactInfoService)
        {
            _supplierService = new SupplierService(addressService, contactInfoService);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_supplierService.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Insert(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}