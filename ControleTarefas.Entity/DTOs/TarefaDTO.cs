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

    }
}
