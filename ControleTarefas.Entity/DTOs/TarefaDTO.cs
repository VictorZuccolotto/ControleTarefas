using ControleTarefas.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Entity.DTOs
{
    public class TarefaDTO
    {
        public string Titulo { get; set; }

        public TarefaDTO()
        {

        }

        public TarefaDTO(string titulo)
        {
            Titulo = titulo;
        }

        public TarefaDTO(Tarefa tarefa)
        {
            Titulo = tarefa.Titulo;
        }
    }
}
