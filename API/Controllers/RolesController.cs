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
    public class RolesController : Controller
    {

        private RolesService _rolesService;

        public RolesController()
        {
            _rolesService = new RolesService();
        }

        [HttpGet("id")]
        public Roles GetById(int id)
        {
            return _rolesService.Get(id);
        }

        [HttpGet]
        public List<Roles> GetAll()
        {
            return _rolesService.GetAll();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
