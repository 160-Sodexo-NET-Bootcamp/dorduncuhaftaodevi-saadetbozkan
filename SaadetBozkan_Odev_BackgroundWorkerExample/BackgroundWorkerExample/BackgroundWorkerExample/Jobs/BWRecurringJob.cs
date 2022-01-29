using Data.DataModel;
using Data.Uow;
using Hangfire;
using System;

namespace BackgroundWorkerExample.Jobs
{
    public class BWRecurringJob
    {
        private readonly IUnitOfWork unitOfWork;
        public BWRecurringJob(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            DoJob();
        }

        public void DoJob()
        {

            //hergün saat 8 ve 17:45 arasında her 15 dakikikadar bir bu işlemi yapar.
            RecurringJob.AddOrUpdate(() => new InserJob(unitOfWork).DoJob(), "0 */15 8-17 ? * *");
            //hergün saat 18 de bu işlemi yapar. 
            RecurringJob.AddOrUpdate(() => new ChangeStatusJob(unitOfWork).DoJob(), "0 0 18 * * ?");
        }
    }
}
