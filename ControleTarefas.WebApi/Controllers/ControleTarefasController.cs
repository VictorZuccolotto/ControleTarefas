using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;
using ControleTarefas.Service.Interface.IServices;
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
        public ActionResult<List<TarefaDTO>> Get()
        {
            return _tarefaService.GetAll();
        }

        [HttpGet("ListarTarefa")]
        public ActionResult<TarefaDTO> Get(string nome)
        {
            return _tarefaService.Get(nome);
        }

        [HttpPost("InserirTarefa")]
        public ActionResult<TarefaDTO> Post(CadastroTarefaModel novaTarefa)
        {
            return _tarefaService.Add(novaTarefa);

        }

        [HttpDelete("DeletarTarefa")]
        public ActionResult<TarefaDTO> Delete(string nomeTarefa)
        {
            return _tarefaService.Delete(nomeTarefa);
        }

        [HttpPut("AlterarTarefa")]
        public ActionResult<TarefaDTO> Put(string titulo, Tarefa novaTarefa)
        {
            return _tarefaService.Update(titulo, novaTarefa);
        }
    }
}
