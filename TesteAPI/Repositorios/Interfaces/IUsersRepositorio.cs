using TesteAPI.Models;

namespace TesteAPI.Repositorios.Interfaces
{
    public interface IUsersRepositorio
    {
        Task<List<UserModel>> BuscarTodosUsuarios(int page, int per_page);
        Task<UserModel> BuscarPorId(int id);
        Task<UserModel> Atualizar(UserModel user, int id);
        Task<bool> Apagar(int id);
        Task<UserModel> Cadastro(UserModel user);
    }
}
