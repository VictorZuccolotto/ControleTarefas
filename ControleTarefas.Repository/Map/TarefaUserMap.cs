using ControleTarefas.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Repository.Map
{
    public class TarefaUserMap : IEntityTypeConfiguration<TarefaUser>
    {
        public void Configure(EntityTypeBuilder<TarefaUser> builder)
        {
            builder.ToTable("tb_tarefausuario");

            builder.HasKey(e => new { e.IdUser, e.IdTarefa });

            builder.Property(e => e.IdTarefa)
                   .HasColumnName("id_tarefa")
                   .IsRequired();

            builder.Property(e => e.IdUser)
                   .HasColumnName("id_usuario")
                   .IsRequired();

            builder.Property(e => e.Concluida)
                   .HasColumnName("flg_concluida")
                   .IsRequired();

            //Relações
            builder.HasOne(e => e.User)
                   .WithMany(e => e.TarefasUsuario)
                   .HasForeignKey(e => e.IdUser);

            builder.HasOne(e => e.Tarefa)
                   .WithMany(e => e.UsuariosTarefa)
                   .HasForeignKey(e => e.IdTarefa);
        }
    }
}
