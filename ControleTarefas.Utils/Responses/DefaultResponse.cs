using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Utils.Responses
{
    public class DefaultResponse
    {
        public HttpStatusCode HttpStatus { get; set; }
        public List<string> Messages { get; set; }
        public object Data { get; set; }

        public DefaultResponse(HttpStatusCode status, List<string> messages)
        {
            HttpStatus = status;
            Messages = messages;
            Data = DateTime.Now;
        }
    }
}
