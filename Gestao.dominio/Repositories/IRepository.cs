using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.dominio
{

    public interface IRepository<TEntity> where TEntity : Entity
    {
        void insert(TEntity entity);
        void update(TEntity entity);
        void delete(TEntity entity);
        TEntity FindByID(params object[] key);
        TEntity FindDetacheByID(params object[] key);
        TEntity FindAsNoTracking(Expression<Func<TEntity,bool>> predicate);
        IEnumerable<TEntity> FindListNoTracking(Expression<Func<TEntity, bool>> predicate);
        System.Data.Common.DbConnection GetDbConnection();

    }

}
