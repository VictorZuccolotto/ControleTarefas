using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;

namespace ControleTarefas.Service.Interface.IServices
{
    public interface IUserService
    {
        public Task<UserDTO> Add(CadastroUsuarioModel user);
        //public UserDTO Update(string email, UserDTO novoUser);
        //public UserDTO Delete(string email);
        public UserDTO Get(string email);
        public Task<List<UserDTO>> GetAll();

    }
}
