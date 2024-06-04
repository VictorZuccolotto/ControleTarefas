using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Repository.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleTarefas.Repository.Repositories
{
    public class TarefaRepository : CrudRepository<Tarefa>,ITarefaRepository
    {
        //private static List<Tarefa> Tarefas { get; set; } = new() { new("Teste"), new("Instalação"), new("Configuração"), new("Criar Projeto"), new("Exercício Prático") };
        public TarefaRepository(Context context) : base(context)
        {
        }

        public Task<Tarefa> GetByTitulo(string titulo, bool asNoTracking = false)
        {
            var query = EntitySet.AsQueryable();

            if (asNoTracking)
                query = query.AsNoTracking();

            return query.FirstOrDefaultAsync(e => e.Titulo.ToLower() == titulo.ToLower());
        }




    }
}
