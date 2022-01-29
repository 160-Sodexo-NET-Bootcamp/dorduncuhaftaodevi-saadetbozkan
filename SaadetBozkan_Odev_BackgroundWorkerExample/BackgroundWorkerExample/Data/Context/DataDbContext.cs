using Data.DataModel;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataDbContext : DbContext, IDataDbContext
    {
        public DbSet<ModelExample> ModelExample { get; set; }
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
