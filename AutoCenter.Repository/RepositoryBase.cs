using AutoCenter.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{ 
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly AutoCenterDbContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public RepositoryBase()
        {
            _db = new AutoCenterDbContext();
            _dbSet = _db.Set<TEntity>();
        }

        public virtual void Create(TEntity entity)
        {
            CheckEntityNotNull(entity);
            _dbSet.Add(entity);
        }

        public virtual void Delete(int id)
        {
            TEntity entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            CheckEntityNotNull(entity);
            _dbSet.Update(entity);
        }

        public virtual void CheckEntityNotNull(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
        }

        public virtual IEnumerable<TEntity> FindAll() => _dbSet.ToList();

        public virtual TEntity FindById(params object[] id) => _dbSet.Find(id);

        public virtual int Save()
        {
            int value = _db.SaveChanges();
            return  value;
        }

        public virtual ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet;

            if (predicate != null)
                query = query.Where(predicate);

            return query.ToList();
        }
    }
}
