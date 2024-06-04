using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;

namespace ControleTarefas.Service.Interface.IServices
{
    public interface ITarefaService
    {
        public Task<TarefaDTO> Add(CadastroTarefaModel novaTarefa);
        public Task<TarefaDTO> Update(string titulo, Tarefa novaTarefa);
        public Task<TarefaDTO> Delete(string titulo);
        public Task<TarefaDTO> Get(string titulo);
        public Task<List<TarefaDTO>> GetAll();

    }
}
