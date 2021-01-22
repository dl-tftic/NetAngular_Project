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
    public class ProductController : Controller, IControllerInterface<Product>
    {
        private ProductService _productService;

        public ProductController(IProductCategoryService productCategoryService)
        {
            _productService = new ProductService(productCategoryService);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }

        public IActionResult Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
