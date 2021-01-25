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
    public class RolesController : Controller, IControllerInterface<Roles>

    {

        private RolesService _rolesService;

        public RolesController()
        {
            _rolesService = new RolesService();
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_rolesService.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            { 
                return Ok(_rolesService.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IActionResult Insert(Roles t)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult Update(Roles t)
        {
            throw new NotImplementedException();
        }
    }
}
