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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : Controller
    {

        private AddressService _addressService;

        public AddressController(ICitiesService citiesService)
        {
            _addressService = new AddressService(citiesService);
        }

        [HttpGet("{id}")]
        public Address GetById(int id)
        {
            return _addressService.Get(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
