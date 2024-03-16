using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteAPI.Data;
using TesteAPI.Models;
using TesteAPI.Repositorios.Interfaces;
using TesteAPI.ViewModels;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsersRepositorio _userRepositorio;

        public LoginController(IUsersRepositorio usersRepositorio)
        {
            _userRepositorio = usersRepositorio;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromServices] SistemaDBContex context, [FromBody] LoginViewModel login)
        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest();
//            }

            var user = await context.Users.FirstOrDefaultAsync(x => x.Username == login.Username);
            var pass = await context.Users.FirstOrDefaultAsync(x => x.Password == login.Password);
            var email = await context.Users.FirstOrDefaultAsync(x => x.Email == login.Email);
            if (user == null && pass == null && email == null)
            {
                return BadRequest(new { mensagem = "Dados invalido" });
            }
            else
            {
                if (user.Username == login.Username && user.Password == login.Password && user.Email == login.Email)
                {
                    return Ok(new { token = "acesso liberado" });
                }
            }
            return BadRequest(new { mensagem = "Dados invalido" });
        }
    }
}
