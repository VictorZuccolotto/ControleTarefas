using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;
using ControleTarefas.Repository.Interface.IRepositories;
using ControleTarefas.Service.Interface.IServices;
using ControleTarefas.Utils.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Service.Services
{
    public class TarefaUserService : ITarefaUserService
    {

        private readonly IUserRepository _userRepository;
        public TarefaUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        //AddUserByIdOnTarefaById
        public async Task AddUserByIdOnTarefaById(AtribuirTarefaModel tarefasUsuario)
        {
            var usuario = await _userRepository.ObterUser(tarefasUsuario.IdUsuario);

            if (usuario != null)
            {
                if (usuario.TarefasUsuario != null && !usuario.TarefasUsuario.Exists(e => e.IdTarefa == tarefasUsuario.IdsTarefa))
                {
                    usuario.TarefasUsuario.Add(new TarefaUser
                    {
                        IdUser = usuario.Id,
                        IdTarefa = tarefasUsuario.IdsTarefa
                    });
                }
            }
        }

        public async Task<List<TarefaDTO>> GetTarefasFromUserById(int id)
        {
            var usuario = await _userRepository.ObterUser(id);
            if (usuario != null)
            {
                var tarefasDto = usuario.TarefasUsuario.Select(e => new TarefaDTO(e.Tarefa)).ToList();
                return tarefasDto;
            }
            throw new GenericException("Usuario não existe");

        }
    }
}
