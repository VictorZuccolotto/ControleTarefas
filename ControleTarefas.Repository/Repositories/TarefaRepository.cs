using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Repository.Interface.IRepositories;

namespace ControleTarefas.Repository.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private static List<Tarefa> Tarefas { get; set; } = new() { new("Teste"), new("Instalação"), new("Configuração"), new("Criar Projeto"), new("Exercício Prático") };


        public Tarefa Update(string novoTitulo, Tarefa tarefa )
        {

            tarefa.Titulo = novoTitulo;
            return tarefa;
        }

        public Tarefa Delete(Tarefa tarefa)
        {
            Tarefas.Remove(tarefa);
            return tarefa;
        }

        public Tarefa Add(Tarefa novaTarefa)
        {
                Tarefas.Add(novaTarefa);
                return novaTarefa;
        }

        public Tarefa? Get(string titulo)
        {
            return Tarefas.FirstOrDefault(x => x.Titulo == titulo);

        }

        public List<Tarefa> GetAll()
        {
            return Tarefas;
        }
    }
}
