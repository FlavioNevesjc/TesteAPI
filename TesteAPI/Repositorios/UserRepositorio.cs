using Microsoft.EntityFrameworkCore;
using TesteAPI.Data;
using TesteAPI.Models;
using TesteAPI.Repositorios.Interfaces;

namespace TesteAPI.Repositorios
{
    public class UserRepositorio : IUsersRepositorio
    {
        private readonly SistemaDBContex _dbContext;
        public UserRepositorio(SistemaDBContex sistemaDbContex)
        {
            _dbContext = sistemaDbContex;
        }

        public async Task<List<UserModel>> BuscarTodosUsuarios(int page, int per_page)
        {
            return await _dbContext.Users.Skip(page * per_page).Take(per_page).ToListAsync();
        }

        public async Task<UserModel> BuscarPorId(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserModel> Atualizar(UserModel users, int id)
        {
            UserModel userId = await BuscarPorId(id);
            if (userId == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontrado no banco de dados.");
            }

            userId.Id = users.Id;
            userId.Username = users.Username;
            userId.Email = users.Email;
            userId.Password = users.Password;
            userId.NomeCompleto = users.NomeCompleto;
    
            _dbContext.Users.Update(userId);
            await _dbContext.SaveChangesAsync();

            return userId;
        }

        public async Task<bool> Apagar(int id)
        {
            UserModel userId = await BuscarPorId(id);
            if (userId == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontrado no banco de dados.");
            }

            _dbContext.Users.Remove(userId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<UserModel> Cadastro(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }
    }
}
