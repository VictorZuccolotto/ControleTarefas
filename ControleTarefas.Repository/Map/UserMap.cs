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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("tb_usuario");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName("id_usuario")
                   .IsRequired();

            builder.Property(e => e.Nome)
                   .HasColumnName("nom_usuario")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.Login)
                   .HasColumnName("lgn_usuario")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .HasColumnName("dsc_email")
                   .IsRequired();

            builder.Property(e => e.ModifiedAt)
                   .HasColumnName("dat_atualizacao")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.Role)
                   .HasColumnName("id_tpperfil")
                   .IsRequired();

        }
    }
}
