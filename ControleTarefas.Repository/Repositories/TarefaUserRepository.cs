using ControleTarefas.Entity.DTOs;
using ControleTarefas.Entity.Entities;
using ControleTarefas.Repository.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace ControleTarefas.Repository.Repositories
{
    public class TarefaUserRepository : CrudRepository<TarefaUser>
    {
        public TarefaUserRepository(Context context) : base(context)
        {
        }
    }
}
