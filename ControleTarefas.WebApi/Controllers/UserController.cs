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
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("ListarTodasUsuarios")]
        public async Task<ActionResult<List<UserDTO>>> Get()
        {
            return await _userService.GetAll();
        }

        [HttpGet("ListarUsuario")]
        public ActionResult<UserDTO> Get(string nome)
        {
            return _userService.Get(nome);
        }

        [HttpPost("InserirUsuario")]
        [Transaction]
        public async Task<ActionResult<UserDTO>> Post(CadastroUsuarioModel user)
        {
            return await _userService.Add(user);

        }

        //[HttpDelete("DeletarTarefa")]
        //public ActionResult<TarefaDTO> Delete(string nomeTarefa)
        //{
        //    return _userService.Delete(nomeTarefa);
        //}

        //[HttpPut("AlterarTarefa")]
        //public ActionResult<TarefaDTO> Put(string titulo, Tarefa novaTarefa)
        //{
        //    return _userService.Update(titulo, novaTarefa);
        //}
    }
}
