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
    public class CountryController : Controller
    {
        private CountryService _countryService;

        public CountryController()
        {
            _countryService = new CountryService();
        }

        [HttpGet("name")]
        public List<Country> GetByName(string name)
        {
            return _countryService.GetByName(name);
        }

        [HttpGet("id")]
        public Country GetById(int id)
        {
            return _countryService.Get(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
