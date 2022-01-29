using Data.Context;
using Data.DataModel;
using Data.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ILogger logger;
        private readonly IConfiguration configuration;
        private readonly DataDbContext context;

        public GenericRepository<ModelExample> ModelExample { get; private set; }
        public UnitOfWork(DataDbContext context, ILoggerFactory logger, IConfiguration configuration)
        {
            this.context = context;
            this.logger = logger.CreateLogger("patika");
            

            ModelExample = new GenericRepository<ModelExample> (context, this.logger);
        }

        public int Complate()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
