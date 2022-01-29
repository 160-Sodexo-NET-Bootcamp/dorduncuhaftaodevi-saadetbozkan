using Data.DataModel;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public interface IDataDbContext
    {
        DbSet<ModelExample> ModelExample { get; set; }
        int SaveChanges();
    }
}
