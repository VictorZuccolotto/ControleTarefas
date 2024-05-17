using ControleTarefas.Utils.Exceptions;
using Microsoft.AspNetCore.Mvc;
namespace ControleTarefas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControleTarefaController : ControllerBase
    {

        private static List<string> Tarefas { get; set; } = new() { new("Teste"), new("Instalação"), new("Configuração"), new("Criar Projeto"), new("Exercício Prático") };

        [HttpGet("ListarTodasTarefas")]
        public ActionResult<List<string>> Get()
        {
            return Tarefas;
        }

        [HttpGet("ListarTarefa")]
        public ActionResult<string> Get(string nome)
        {
            var tarefa = Tarefas.IndexOf(nome);
            if (tarefa == -1)
                throw new GenericException("Tarefa não existe");
            //return NotFound();
            return Tarefas[tarefa];
        }

        [HttpPost("InserirTarefa")]
        public ActionResult<string> Post(string novaTarefa)
        {
            var tarefa = Tarefas.IndexOf(novaTarefa);
            if (tarefa != -1)
                throw new BusinessException("Tarefa já existe");
            //return Conflict();
            Tarefas.Add(novaTarefa);
            return Created("", novaTarefa);

        }

        [HttpDelete("DeletarTarefa")]
        public ActionResult<string> Delete(string nomeTarefa)
        {
            var tarefa = Tarefas.IndexOf(nomeTarefa);
            if (tarefa == -1)
                throw new GenericException("Tarefa não existe");
            //return NotFound();
            Tarefas.Remove(nomeTarefa);
            return nomeTarefa;
        }

        [HttpPut("AlterarTarefa")]
        public ActionResult<string> Put(string nomeTarefa, string novaTarefa)
        {
            var index = Tarefas.IndexOf(nomeTarefa);
            if (index == -1)
                throw new GenericException("Tarefa não existe");
            //return NotFound();
            Tarefas[index] = novaTarefa;
            return novaTarefa;
        }
    }
}
