using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Repository
{
    public interface ITransactionManager
    {
        Task BeginTransactionAsync(IsolationLevel isolationLevel);

        Task CommitTransactionsAsync();

        Task RollbackTransactionsAsync();
    }
}
