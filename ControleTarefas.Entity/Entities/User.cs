using ControleTarefas.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Entity.Entities
{
    public class User
    {
        public string Nome{ get; set; }
        public string Email{ get; set; }
        public PerfilEnum Role{ get; set; }

        public DateTime ModifiedAt { get; set; }  
        public User()
        {
            
        }
        public User(string email)
        {
            Email=email;
        }
    }
}
