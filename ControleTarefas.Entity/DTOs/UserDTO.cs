using ControleTarefas.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Entity.DTOs
{
    public class UserDTO
    {

        public string Nome { get; set; }
        public string Email { get; set; }

        public UserDTO(string email)
        {
            Email = email;
        }

        public UserDTO(User user)
        {
            Email = user.Email;
            Nome = user.Nome;
        }
    }
}
