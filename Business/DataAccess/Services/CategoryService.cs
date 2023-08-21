using AppCore.DataAccess.EntityFrameWork.Bases;
using Business.DataAccess.Contexts;
using Business.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.DataAccess.Services
{

    public abstract class CategoryServiceBase : Service<Category>
    {
        protected CategoryServiceBase(DbContext db) : base(db)
        {
        }
    }

    public class CategoryService : CategoryServiceBase
    {
        public CategoryService(Db db) : base(db)
        {
        }
    }
}
