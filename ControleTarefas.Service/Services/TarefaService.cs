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

        public async Task<TarefaDTO> Add(CadastroTarefaModel tarefaModel)
        {
            Tarefa tarefa = await _tarefaRepository.GetByTitulo(tarefaModel.Titulo);
            if (tarefa is null)
                return new TarefaDTO( await _tarefaRepository.Add(new Tarefa(tarefaModel)));
            else
                throw new BusinessException("Já existe no banco de dados");
        }

        public async Task<TarefaDTO> Delete(string titulo)
        {
            Tarefa tarefa = await _tarefaRepository.GetByTitulo(titulo);
            if (tarefa is not null)
                return new TarefaDTO( await _tarefaRepository.Delete(tarefa));
            else
                throw new GenericException("Tarefa não existe");
        }

        public async Task<TarefaDTO> Get(string titulo)
        {
            Tarefa tarefa = await _tarefaRepository.GetByTitulo(titulo);
            if (tarefa is not null)
                return new TarefaDTO(tarefa);
            else
                throw new GenericException("Tarefa nao existe");
        }

        public async Task<List<TarefaDTO>> GetAll()
        {
            var Tarefas = await _tarefaRepository.GetAll();
            return Tarefas.Select(x => new TarefaDTO(x.Titulo))
                            .Distinct()
                                .OrderBy(x => x.Titulo) 
                                    .ToList();
        }

        public async Task<TarefaDTO> Update(string titulo, Tarefa novaTarefa)
        {
            Tarefa tarefa = await _tarefaRepository.GetByTitulo(titulo);
            if (tarefa is not null)
            {
                novaTarefa.Id = tarefa.Id;
                return new TarefaDTO( await _tarefaRepository.Update(novaTarefa));
            }
            else
            {

                throw new GenericException("Tarefa nao existe");
            }

        }
    }
}
