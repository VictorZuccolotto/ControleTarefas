using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Entity.Model;
using ControleTarefas.Service.Interface.IServices;
using ControleTarefas.Utils;
using Microsoft.AspNetCore.Mvc;
namespace ControleTarefas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaUserController : ControllerBase
    {

        private readonly ITarefaUserService _tarefaUserService;

        public TarefaUserController(ITarefaUserService tarefaUserService)
        {
            _tarefaUserService = tarefaUserService;
        }

        [HttpPost("AtribuirTarefa")]
        [Transaction]
        public async Task<ActionResult> Post(AtribuirTarefaModel atribuirTarefaModel)
        {
            await _tarefaUserService.AddUserByIdOnTarefaById(atribuirTarefaModel);
            return Ok();
        }

        [HttpGet("ListarTarefasDeUsuario")]
        public async Task<ActionResult<List<TarefaDTO>>> Get(int id)
        {
            return await _tarefaUserService.GetTarefasFromUserById(id);
        }

    }
}
