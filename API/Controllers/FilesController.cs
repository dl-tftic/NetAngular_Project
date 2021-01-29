using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Services;
using BLL.Models;
using Microsoft.AspNetCore.Http;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilesController : Controller, Interface.IControllerInterface<Files>
    {

        private FilesService _filesService;

        public FilesController()
        {
            _filesService = new FilesService();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_filesService.Delete(id));
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
                return Ok(_filesService.GetAll());
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
                return Ok(_filesService.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Insert([FromBody] Files file)
        {
            var filetemp = Request.Form.Files[0];

            try
            {
                return Ok(_filesService.Insert(file));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Insert()
        {

            try
            {

                var fileCollection = await Request.ReadFormAsync();
                IFormFile angularFile = fileCollection.Files[0];

                if (angularFile.Length > 0)
                {

                    Files file = new Files();
                    file.Name = Request.Form["name"];
                    file.Description = Request.Form["description"];
                    file.CreateBy = Convert.ToInt32(Request.Form["createBy"]);
                    file.FileName = angularFile.FileName;
                    file.FileExension = Path.GetExtension(file.FileName);
                    file.FileSize = angularFile.Length;

                    using (var ms = new MemoryStream())
                    {
                        angularFile.CopyTo(ms);
                        file.FileByte = ms.ToArray();
                    }

                    return Ok(_filesService.Insert(file));
                }
                else return BadRequest("File is empty");

                ;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        public IActionResult Update(Files file)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Upload()
        {
            // var file = await Request.Form.Files[0];
            var file = await Request.ReadFormAsync();

            List<string> listValues = new List<string>();
            foreach (string key in Request.Form.Keys)
            {
                listValues.Add(Request.Form[key]);
            }

            return BadRequest();
            //if (file.Length > 0)
            //{
            //    using (var ms = new MemoryStream())
            //    {
            //        file.CopyTo(ms);
            //        var fileBytes = ms.ToArray();
            //        string s = Convert.ToBase64String(fileBytes);
            //        // act on the Base64 data

            //        // _filesService.
            //    }

            //    return Ok();
            //}
            //else return BadRequest("File is empty");
        }
    }
}
