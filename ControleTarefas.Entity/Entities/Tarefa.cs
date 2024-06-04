using ControleTarefas.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Entity.Entities
{
    public class Tarefa : IdEntity<int>
    {
        public string Titulo { get; set; }

        public Tarefa()
        {
            
        }

        public Tarefa(string titulo)
        {
            Titulo = titulo;   
        }

        public Tarefa(CadastroTarefaModel tarefa)
        {
            Titulo = tarefa.Titulo;
        }

    }

   
}
