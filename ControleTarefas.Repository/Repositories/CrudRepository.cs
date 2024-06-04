using ControleTarefas.Entity.Entities;
using ControleTarefas.Repository.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTarefas.Repository.Repositories
{
    public class CrudRepository<T> : ICrudRepository<T> where T : class, IEntity
    {

        protected readonly Context _context;
        protected virtual DbSet<T> EntitySet { get; }

        public CrudRepository(Context context)
        {
            _context = context;
            EntitySet = _context.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            var entityEntry = await EntitySet.AddAsync(entity);

            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task<T> Delete(T entity)
        {
            var entitySet = EntitySet.Remove(entity);

            await _context.SaveChangesAsync();

            return entitySet.Entity;
        }

        public async Task<T> DeleteById(object id)
        {
            var entity = await EntitySet.FindAsync(id);

            if (entity == null)
                return null;

            return await Delete(entity);
        }

        public Task<List<T>> GetAll() => EntitySet.ToListAsync();

        public async Task<T> GetById(object id)
        {
            return await EntitySet.FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            var entityEntry = EntitySet.Update(entity);

            await _context.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}
