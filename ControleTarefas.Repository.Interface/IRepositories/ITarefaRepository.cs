using ControleTarefas.Entity.Entities;

namespace ControleTarefas.Repository.Interface.IRepositories
{
    public interface ITarefaRepository: ICrudRepository<Tarefa>
    {

        Task<Tarefa> GetByTitulo(string titulo, bool asNoTracking = false);
    }
}
