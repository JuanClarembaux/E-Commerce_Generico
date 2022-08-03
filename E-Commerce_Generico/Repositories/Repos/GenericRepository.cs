using E_Commerce_Generico.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Generico.Repositories.Repos
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;
        internal DbSet<T> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll() => dbSet.ToList();
        public virtual T findId(object Id)
        {

            return dbSet.Find(Id);

        }
        public virtual void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
    }
}
