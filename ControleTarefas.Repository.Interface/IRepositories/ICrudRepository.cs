using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Repository.Interface.IRepositories
{
    public interface ICrudRepository<T> where T : class
    {
        T GetById(int id);
        T GetById(string id);
        T UpdateById(T entity);
        T DeleteById(int id);
        T DeleteById(string id);
        T AddById(T entity);
        List<T> GetAll();


             
    }
}
