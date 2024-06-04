using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Utils
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method, Inherited =true,AllowMultiple =false)]
    public class Transaction : Attribute
    {
        public IsolationLevel IsolationLevel { get; set; } = IsolationLevel.ReadCommitted;

        public Transaction() { }

        public Transaction(IsolationLevel isolationLevel)
        {
            IsolationLevel = isolationLevel;
        }
    }
}
