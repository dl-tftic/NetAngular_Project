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
    public class AddressController : Controller, IControllerInterface<Address>
    {

        private AddressService _addressService;

        public AddressController(ICitiesService citiesService)
        {
            _addressService = new AddressService(citiesService);
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_addressService.Get(id));
        }

        public IActionResult Insert(Address t)
        {
            throw new NotImplementedException();
        }
    }
}
