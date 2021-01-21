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
    public class CitiesController : Controller
    {
        private CitiesService _citiesService;

        public CitiesController(ICountryService countryService)
        {
            _citiesService = new CitiesService(countryService);
        }

        [HttpGet("name")]
        public List<Cities> GetByName(string name)
        {
            return _citiesService.GetByName(name);
        }

        [HttpGet("id")]
        public Cities GetById(int id)
        {
            return _citiesService.Get(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
