using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AutoCenter.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();
        ICollection<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity FindById(params object[] id);
        bool Create(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
        bool Save();
    }
}
