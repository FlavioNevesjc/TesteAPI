using Microsoft.AspNetCore.Mvc;
using TesteAPI.Models;
using TesteAPI.Repositorios.Interfaces;

namespace TesteAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepositorio _userRepositorio;

        public UsersController(IUsersRepositorio usersRepositorio)
        {
            _userRepositorio = usersRepositorio;
        }

        //Endpoint para lista de usuários
        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> BuscarTodosUsuario(int page, int per_page)
        {
            if (per_page == 0)
            {
                per_page = 15;
            }
           
            List<UserModel> users = await _userRepositorio.BuscarTodosUsuarios(page, per_page);
            return Ok(users);
        }

        //Endpoint usuário por id
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> BuscarPorId(int id)
        {
            UserModel user = await _userRepositorio.BuscarPorId(id);
            return Ok(user);
        }

        //Endpoint atualizar usuário por id
        [HttpPut("{id}")]
        public async Task<ActionResult<UserModel>> AtualizarUsuario([FromBody] UserModel userModel, int id)
        {
            userModel.Id = id;
            UserModel user = await _userRepositorio.Atualizar(userModel, id);
            return Ok(user);
        }

        //Endpoint deletar usuário por id
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserModel>> ApagarUsuario(int id)
        {
            bool delete = await _userRepositorio.Apagar(id);
            return Ok(delete);
        }

        //      EndPoint criado para realizar alimentação do banco de dados via API
        /*        [HttpPost]
                public async Task<ActionResult<UserModel>> CadastrarUsuario([FromBody] UserModel userModel)
                {
                    UserModel user = await _userRepositorio.Cadastro(userModel);
                    return Ok(user);
                }*/        
    }
}
