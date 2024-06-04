using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Entity.Entities
{
    public class TarefaUser : IEntity
    {

        public int IdUser { get; set; }
        public int IdTarefa { get; set; }
        public bool Concluida { get; set;}
        public Tarefa Tarefa { get; set;} 
        public User User { get; set;}

        public TarefaUser()
        {
            
        }
    }
}
