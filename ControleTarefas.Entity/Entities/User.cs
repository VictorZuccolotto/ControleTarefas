using ControleTarefas.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Entity.Entities
{
    public class User: IdEntity<int>
    {
        public string Nome{ get; set; }
        public string Email{ get; set; }

        public string Login { get; set; }
        public PerfilEnum Role{ get; set; }

        public DateTime ModifiedAt { get; set; }  

        public List<TarefaUser> TarefasUsuario { get; set; }
        //TarefaUser  /\
        public User()
        {
            
        }
        public User(string email)
        {
            Email=email;
        }
    }
}
