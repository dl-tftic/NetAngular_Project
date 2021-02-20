using API.Models;
using BLL.Interface;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : Controller
    {
        private AccountService _accountService;

        public AuthController(IAccountService accountService)
        {
            this._accountService = (AccountService)accountService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] Auth auth)
        {
            string apiAddress = "https://localhost:44381";

            if (auth.UserName == null) return BadRequest("");

            if (this._accountService.CheckPassword(auth.UserName, auth.Password))
            // if (auth.UserName == "testLogin")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var sigingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                Account account = this._accountService.GetByLogin(auth.UserName);

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, account.Login),
                    new Claim(ClaimTypes.Role, account.Role.Role),
                    new Claim("Id", account.Id.ToString())
                };

                var tokenOptions = new JwtSecurityToken(
                    issuer: apiAddress,
                    audience: apiAddress,
                    // claims: new List<Claim>(),
                    claims : claims,
                    expires: DateTime.Now.AddDays(5),
                    signingCredentials: sigingCredentials
                    );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });
            }

            return Unauthorized();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
