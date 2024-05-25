using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;
using ControleTarefas.Service.Interface.IServices;
using ControleTarefas.Utils;
using ControleTarefas.Utils.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace ControleTarefas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleTarefaController : ControllerBase
    {

        private readonly ITarefaService _tarefaService;

        public ControleTarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet("ListarTodasTarefas")]
        public async Task<ActionResult<List<TarefaDTO>>> Get()
        {
            return  await _tarefaService.GetAll();
        }

        [HttpGet("ListarTarefa")]
        public async Task<ActionResult<TarefaDTO>> Get(string nome)
        {
            return await _tarefaService.Get(nome);
        }


        [HttpPost("InserirTarefa")]
        [Transaction]
        public async Task<ActionResult<TarefaDTO>> Post(CadastroTarefaModel novaTarefa)
        {
            return await _tarefaService.Add(novaTarefa);

        }

        [HttpDelete("DeletarTarefa")]
        [Transaction]
        public async Task<ActionResult<TarefaDTO>> Delete(string nomeTarefa)
        {
            return  await _tarefaService.Delete(nomeTarefa);
        }

        [HttpPut("AlterarTarefa")]
        [Transaction]
        public async Task<ActionResult<TarefaDTO>> PutAsync(string titulo, Tarefa novaTarefa)
        {
            return await _tarefaService.Update(titulo, novaTarefa);
        }
    }
}
