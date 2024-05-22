using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;

namespace ControleTarefas.Service.Interface.IServices
{
    public interface ITarefaService
    {
        public TarefaDTO Add(CadastroTarefaModel novaTarefa);
        public TarefaDTO Update(string titulo, Tarefa novaTarefa);
        public TarefaDTO Delete(string titulo);
        public TarefaDTO Get(string titulo);
        public List<TarefaDTO> GetAll();

    }
}
