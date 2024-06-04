using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Service.Interface.IServices
{
    public interface ITarefaUserService
    {
        Task AddUserByIdOnTarefaById(AtribuirTarefaModel atribuirTarefaModel);

        Task<List<TarefaDTO>> GetTarefasFromUserById(int id);
    }
}
