using TesteAPI.Models;

namespace TesteAPI.Repositorios.Interfaces
{
    public interface IUsersRepositorio
    {
        Task<List<UserModel>> BuscarTodosUsuarios(int page, int per_page);
        Task<UserModel> BuscarPorId(int id);
        Task<UserModel> Atualizar(UserModel user, int id);
        Task<bool> Apagar(int id);
        
//      Criado para realizar alimentação do banco de dados via API
//        Task<UserModel> Cadastro(UserModel user);
    }
}
