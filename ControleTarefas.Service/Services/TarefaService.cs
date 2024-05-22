using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;
using ControleTarefas.Repository.Interface.IRepositories;
using ControleTarefas.Service.Interface.IServices;
using ControleTarefas.Utils.Exceptions;

namespace ControleTarefas.Service.Services
{
    public class TarefaService : ITarefaService
    {

        private readonly ITarefaRepository _tarefaRepository;


        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public TarefaDTO Add(CadastroTarefaModel novaTarefa)
        {
            Tarefa tarefa = _tarefaRepository.Get(novaTarefa.Titulo);
            if (tarefa is null)
                return new TarefaDTO(_tarefaRepository.Add(new Tarefa(novaTarefa)));
            else
                throw new BusinessException("Já existe no banco de dados");
        }

        public TarefaDTO Delete(string titulo)
        {
            Tarefa tarefa = _tarefaRepository.Get(titulo);
            if (tarefa is not null)
                return new TarefaDTO(_tarefaRepository.Delete(tarefa).Titulo);
            else
                throw new GenericException("Tarefa não existe");
        }

        public TarefaDTO Get(string titulo)
        {
            Tarefa tarefa = _tarefaRepository.Get(titulo);
            if (tarefa is not null)
                return new TarefaDTO(tarefa.Titulo);
            else
                throw new GenericException("Tarefa nao existe");
        }

        public List<TarefaDTO> GetAll()
        {
            return _tarefaRepository.GetAll()
                                    .Select(x => new TarefaDTO(x.Titulo))
                                    .Distinct()
                                    .OrderBy(x => x.Titulo) 
                                    .ToList();
        }

        public TarefaDTO Update(string titulo, Tarefa novaTarefa)
        {
            Tarefa tarefa = _tarefaRepository.Get(titulo);
            if (tarefa is not null)
                return new TarefaDTO(_tarefaRepository.Update(novaTarefa.Titulo, tarefa).Titulo);
            else
                throw new GenericException("Tarefa nao existe");

        }
    }
}
