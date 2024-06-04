using ControleTarefas.Entity.Entities;
using ControleTarefas.Repository.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleTarefas.Repository.Repositories
{
    public class UserRepository : CrudRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public User GetByEmail(string email)
        {
            var user = EntitySet.FirstOrDefault(usuario => usuario.Email.Equals(email));
            return user;
        }

        public async Task<User> ObterUser(int idUsuario)
        {
            var query = EntitySet.Include(e => e.TarefasUsuario)
                                 .ThenInclude(e => e.Tarefa)
                                 .Where(e => e.Id == idUsuario);

            return await query.FirstOrDefaultAsync();
        }
    }
}
