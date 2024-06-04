using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Enum;
using ControleTarefas.Entity.Model;
using ControleTarefas.Repository.Interface.IRepositories;
using ControleTarefas.Service.Interface.IServices;
using ControleTarefas.Utils.Exceptions;

namespace ControleTarefas.Service.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;


        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Add(CadastroUsuarioModel novoUser)
        {
            User user = _userRepository.GetByEmail(novoUser.Email);
            if (user is null)
            {
                var usr = new User() {
                    Email = novoUser.Email,
                    Nome = novoUser.Nome,
                    Login = novoUser.Email,
                    Role = PerfilEnum.Aluno,
                    ModifiedAt = DateTime.Now
                };
                return new UserDTO(await _userRepository.Add(usr));
            }
            else
                throw new BusinessException("Já existe no banco de dados");
        }

        public UserDTO Get(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDTO>> GetAll()
        {
            
           var lista = await _userRepository.GetAll();
           return lista.Select(e => new UserDTO(e)).ToList();
           
        }
    }
}
