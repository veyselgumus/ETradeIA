using Business.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.DataAccess.Contexts
{
    public class Db : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        public Db(DbContextOptions options) : base(options)
        { 
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Windows Authentication
        //    //string connectionString = "server=.\\SQLEXPRESS;database=ETradeDB;trusted_connection=true;multipleactiveresultsets=true;trustservercertificate=true;";

        //    // SQL Server Authentication
        //    string connectionString = "server=.\\SQLEXPRESS;database=ETradeDB;user id=sa;password=sa;multipleactiveresultsets=true;trustservercertificate=true;";

        //    optionsBuilder.UseSqlServer(connectionString);
        //}
    }
    
}
