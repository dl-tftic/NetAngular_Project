using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using BLL.Models;
using API.Interface;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : Controller, IControllerInterface<Country>
    {
        private CountryService _countryService;

        public CountryController()
        {
            _countryService = new CountryService();
        }

        [HttpGet("name")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_countryService.GetByName(name));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_countryService.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IActionResult GetAll()
        {
            try
            {
                return Ok(_countryService.GetAll());
                // throw new NotImplementedException();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IActionResult Insert(Country t)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Update(Country t)
        {
            throw new NotImplementedException();
        }
    }
}
