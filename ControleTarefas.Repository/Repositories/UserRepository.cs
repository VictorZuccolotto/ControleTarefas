using ControleTarefas.Entity.Entities;
using ControleTarefas.Repository.Interface.IRepositories;

namespace ControleTarefas.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> Usuarios { get; set; } = new() { new("Antonio@Pitang.com"), new("Bernardo@Pitang.com"), new("Claudia@Pitang.com"), new("Danilo@Pitang.com"), new("Eduarda@Pitang.com") };


        //public User Update(string email, User user )
        //{
        //    var u = Usuarios.FindIndex(x => x.Email == email);
        //    Usuarios[u] = user;
        //    return user;
        //}

        //public User Delete(User user)
        //{
        //    Usuarios.Remove(user);
        //    return user;
        //}

        public User Add(User user)
        {
            Usuarios.Add(user);
            return user;
        }

        public User? Get(string email)
        {
            return Usuarios.FirstOrDefault(x => x.Email == email);

        }

        public List<User> GetAll()
        {
            return Usuarios;
        }
    }
}
