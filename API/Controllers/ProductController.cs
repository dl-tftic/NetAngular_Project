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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private ProductService _productService;

        public ProductController(IProductCategoryService productCategoryService)
        {
            _productService = new ProductService(productCategoryService);
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome";
        }

        [HttpGet("ById/{id}")]
        public Product GetById(int id)
        {
            return _productService.Get(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
