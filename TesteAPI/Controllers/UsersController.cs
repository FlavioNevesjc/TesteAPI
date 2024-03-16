using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAPI.Models;
using TesteAPI.Repositorios.Interfaces;

namespace TesteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepositorio _userRepositorio;

        public UsersController(IUsersRepositorio usersRepositorio)
        {
            _userRepositorio = usersRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> BuscarTodosUsuario(int page, int per_page)
        {
                List<UserModel> users = await _userRepositorio.BuscarTodosUsuarios(page, per_page);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> BuscarPorId(int id)
        {
            UserModel user = await _userRepositorio.BuscarPorId(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> AtualizarUsuario([FromBody] UserModel userModel, int id)
        {
            userModel.Id = id;
            UserModel user = await _userRepositorio.Atualizar(userModel, id);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> ApagarUsuario(int id)
        {
            bool delete = await _userRepositorio.Apagar(id);
            return Ok(delete);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> CadastrarUsuario([FromBody] UserModel userModel)
        {
            UserModel user = await _userRepositorio.Cadastro(userModel);
            return Ok(user);
        }


    }
}
