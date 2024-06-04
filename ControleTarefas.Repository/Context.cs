using ControleTarefas.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Repository
{
    public class Context : DbContext
    {
        //public DbSet<Tarefa> Tarefas { get; set; }
        //public DbSet<TarefaUser> TarefaUsuario { get; set; }
        //public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
