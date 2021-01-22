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
    public class CategoryController : Controller, IControllerInterface<Category>
    {
        private CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_categoryService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Category category)
        {
            try
            {
                return Ok(_categoryService.Insert(category));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_categoryService.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
