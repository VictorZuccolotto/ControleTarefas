using ControleTarefas.Entity.Entities;

namespace ControleTarefas.Repository.Interface.IRepositories
{
    public interface ITarefaRepository
    {
        public Tarefa Get(string titulo);
        public List<Tarefa> GetAll();
        public Tarefa Add(Tarefa tarefa);
        public Tarefa Update(string novoTitulo, Tarefa tarefa);
        public Tarefa Delete(Tarefa titulo);


    }
}
