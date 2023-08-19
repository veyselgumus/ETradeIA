using AppCore.Records.Bases;
using AppCore.Results.Bases;
using System.Linq.Expressions;

namespace AppCore.DataAccess.EntityFrameWork.Bases
{
    public interface IService<TEntity> :IDisposable where TEntity : Record,new()
    {
        IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] entitiesToInclude);

        Result Add(TEntity entity,bool save=true);
        Result Update(TEntity entity, bool save = true);
        Result Delete(Expression<Func<TEntity,bool>> preticate, bool save = true);
        int Save();


    }
}
