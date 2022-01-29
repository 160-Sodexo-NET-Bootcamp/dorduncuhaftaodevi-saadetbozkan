using Data.DataModel;
using Data.Uow;
using Hangfire;
using System;
using System.Linq;

namespace BackgroundWorkerExample.Jobs
{
    public class InserJob
    {

        private readonly IUnitOfWork unitOfWork;
        public InserJob(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void DoJob()
        {
            // randım veri üretme;
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // veri tabanına veri ekler.
            var modelExample = new ModelExample();
            modelExample.Title = randomString;
            modelExample.Status = random.Next().ToString();

            unitOfWork.ModelExample.Add(modelExample);

            unitOfWork.Complate();

        }
    }
}

