using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
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

        public UserDTO Add(CadastroUsuarioModel novoUser)
        {
            User user = _userRepository.Get(novoUser.Email);
            if (user is null)
            {
                var usr = new User() {
                    Email = novoUser.Email,
                    Nome = novoUser.Nome
                };
                return new UserDTO(_userRepository.Add(usr));
            }
            else
                throw new BusinessException("Já existe no banco de dados");
        }

        //public UserDTO Delete(string titulo)
        //{
        //    User tarefa = _userRepository.Get(titulo);
        //    if (tarefa is not null)
        //        return new UserDTO(_userRepository.Delete(tarefa).Titulo);
        //    else
        //        throw new GenericException("User não existe");
        //}

        public UserDTO Get(string titulo)
        {
            User tarefa = _userRepository.Get(titulo);
            if (tarefa is not null)
                return new UserDTO(tarefa.Email);
            else
                throw new GenericException("User nao existe");
        }

        public List<UserDTO> GetAll()
        {
            return _userRepository.GetAll()
                                    .Select(x => new UserDTO(x.Email))
                                    .Distinct()
                                    .OrderBy(x => x.Email) 
                                    .ToList();
        }

        //public UserDTO Update(string titulo, User novaTarefa)
        //{
        //    User tarefa = _userRepository.Get(titulo);
        //    if (tarefa is not null)
        //        return new UserDTO(_userRepository.Update(novaTarefa.Titulo, tarefa).Titulo);
        //    else
        //        throw new GenericException("User nao existe");

        //}
    }
}
