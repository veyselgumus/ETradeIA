using AppCore.DataAccess.EntityFrameWork.Bases;
using Business.DataAccess.Contexts;
using Business.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.DataAccess.Services
{
    public abstract class ProductServiceBase : Service<Product>
    {
        protected ProductServiceBase(Db db) : base(db)
        {
        }
    }

    public class ProductService : ProductServiceBase
    {
        public ProductService(Db db) : base(db)
        {
        }
    }
}
