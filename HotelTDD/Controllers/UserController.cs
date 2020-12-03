using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelTDD.Services.Interface;
using HotelTDD.Services.User;
using HotelTDD.Services.User.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelTDD.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Authorize(Roles = "adm")]
        public IActionResult Create([FromBody] UserCreateRequest user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Usuário inválido.");

                _userService.Create(user);

                return Created(string.Empty, "User criado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Não foi possivel criar o usuário: {ex}");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(string email, string password)
        {
            var result = _userService.Login(email, password);
            return Ok(new ObjectResult(result));
        }
    }
}