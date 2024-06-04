using ControleTarefas.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Repository.Interface.IRepositories
{
    public interface ICrudRepository<T> where T : class,IEntity
    {
        Task<T> GetById(object id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<T> DeleteById(object id);
        Task<List<T>> GetAll();


             
    }
}
