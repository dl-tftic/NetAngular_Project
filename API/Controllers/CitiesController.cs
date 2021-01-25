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
    public class CitiesController : Controller, IControllerInterface<Cities>
    {
        private CitiesService _citiesService;

        public CitiesController(ICountryService countryService)
        {
            _citiesService = new CitiesService(countryService);
        }

        [HttpGet("name")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_citiesService.GetByName(name));
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
                return Ok(_citiesService.Get(id));
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
                return Ok(_citiesService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IActionResult Insert(Cities t)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Update(Cities t)
        {
            throw new NotImplementedException();
        }
    }
}
