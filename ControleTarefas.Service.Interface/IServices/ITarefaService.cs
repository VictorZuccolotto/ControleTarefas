using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;

namespace ControleTarefas.Service.Interface.IServices
{
    public interface ITarefaService
    {
        public TarefaDTO Add(Tarefa novaTarefa);
        public TarefaDTO Update(string titulo, Tarefa novaTarefa);
        public TarefaDTO Delete(string titulo);
        public TarefaDTO Get(string titulo);
        public List<TarefaDTO> GetAll();

    }
}
