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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            return _categoryService.Get(id);
        }

        [HttpGet]
        public List<Category> GetAll(int id)
        {
            return _categoryService.GetAll();
        }

        [HttpPost]
        public int Post([FromBody] Category category)
        {
            return _categoryService.Insert(category);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _categoryService.Delete(id);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
