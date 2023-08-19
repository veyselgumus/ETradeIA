using AppCore.Records.Bases;
using AppCore.Results;
using AppCore.Results.Bases;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppCore.DataAccess.EntityFrameWork.Bases
{
    //repository patern uygulanacak.
    //service -> repository
    //CRUD işlemleri gerçekleştireceğiz.

    public abstract class Service<TEntity> : IService<TEntity> where TEntity : Record, new()
    {
        const string _errorMessage = "Changes not saved!";
        protected readonly DbContext _db;

        protected Service(DbContext db)
        {
            _db = db;
        }

        public virtual Result Add(TEntity entity,bool save=true)
        {
            _db.Set<TEntity>().Add(entity);
            if(save) 
            {
                Save();
                return new SuccessResult("Added successfully.");
            }
            return new ErrorResult(_errorMessage);
            
        }

        
        public Result Delete(Expression<Func<TEntity, bool>> preticate, bool save = true)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db?.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            var query=_db.Set<TEntity>().AsQueryable();
            foreach(var entity in entitiesToInclude) 
            {
                query=query.Include(entity);
            }
            return query;
        }

        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity,bool>> predicate, params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            var query = Query(entitiesToInclude);
            query = query.Where(predicate);
            return query;
        }

        public virtual IQueryable<TEntity> QueryAsNoTracking( params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            return Query(entitiesToInclude).AsNoTracking();
        }

        public virtual IQueryable<TEntity> QueryAsNoTracking(Expression<Func<TEntity, bool>> predicate,params Expression<Func<TEntity, object>>[] entitiesToInclude)
        {
            return QueryAsNoTracking(entitiesToInclude).Where(predicate);
        }

        public int Save()
        {
            try
            {
                return _db.SaveChanges();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public Result Update(TEntity entity, bool save = true)
        {
            throw new NotImplementedException();
        }
    }
}
