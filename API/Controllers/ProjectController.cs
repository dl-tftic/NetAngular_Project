using Microsoft.AspNetCore.Mvc;
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
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {

        private ProjectService _projectService;

        public ProjectController(IAddressService addressService, IProjectCategoryService projectCategoryService)
        {
            _projectService = new ProjectService(addressService, projectCategoryService);
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome";
        }

        [HttpGet("ById/{id}")]
        public Project GetById(int id)
        {
            return _projectService.Get(id);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
