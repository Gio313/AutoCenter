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
        private readonly AutoCenterDbContext _db;
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(AutoCenterDbContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public virtual bool Create(TEntity entity)
        {
            CheckEntityNotNull(entity);
            _dbSet.Add(entity);
            return Save();  
        }

        public virtual bool Delete(int id)
        {
            TEntity entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            return Save();
        }

        public virtual bool Update(TEntity entity)
        {
            CheckEntityNotNull(entity);
            _dbSet.Update(entity);
            return Save();
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

        public virtual bool Save() => _db.SaveChanges() > 0;

        public virtual ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet;

            if (predicate != null)
                query = query.Where(predicate);

            return query.ToList();
        }
    }
}
