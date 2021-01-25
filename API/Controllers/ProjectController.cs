using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using BLL.Models;
using Newtonsoft.Json.Linq;
using API.Interface;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : Controller, IControllerInterface<Project>
    {

        private ProjectService _projectService;

        public ProjectController(IAddressService addressService, IProjectCategoryService projectCategoryService)
        {
            _projectService = new ProjectService(addressService, projectCategoryService);
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_projectService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_projectService.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        public IActionResult Insert(Project t)
        {
            throw new NotImplementedException();
        }

        public IActionResult Update(Project t)
        {
            throw new NotImplementedException();
        }
    }
}
