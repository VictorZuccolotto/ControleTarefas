using ControleTarefas.Entity.Entities;

namespace ControleTarefas.Repository.Interface.IRepositories
{
    public interface IUserRepository : ICrudRepository<User>
    {

        public User GetByEmail(string email);

        public Task<User> ObterUser(int id);
    }
}
