using ControleTarefas.Entity.Entities;

namespace ControleTarefas.Repository.Interface.IRepositories
{
    public interface IUserRepository
    {
        public User Get(string titulo);
        public List<User> GetAll();
        public User Add(User user);
        //public User Update(string novoTitulo, User tarefa);
        //public User Delete(User titulo);


    }
}
