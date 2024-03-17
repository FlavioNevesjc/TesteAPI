using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteAPI.Data;
using TesteAPI.Repositorios.Interfaces;
using TesteAPI.ViewModels;

namespace TesteAPI.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsersRepositorio _userRepositorio;

        public LoginController(IUsersRepositorio usersRepositorio)
        {
            _userRepositorio = usersRepositorio;
        }


        // Endpoint para login
        [HttpPost]
        public async Task<IActionResult> Login([FromServices] SistemaDBContex context, [FromBody] LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = await context.Users.FirstOrDefaultAsync(x => x.Username == login.Username);

            if (user == null)
            {
                return BadRequest(new { mensagem = "Falha no login" });
            }
            else
            {
                if (user.Username == login.Username && user.Password == login.Password)
                {
                    return Ok(new { token = "Login efetuado com sucesso" });
                }
                else
                {
                    return BadRequest(new { mensagem = "Falha no login" });
                }
            }
        }
    }
}
