using Data.DataModel;
using Data.Uow;
using Hangfire;
using System;

namespace BackgroundWorkerExample.Jobs
{
    public class ChangeStatusJob
    {
        private readonly IUnitOfWork unitOfWork;
        public ChangeStatusJob(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void DoJob()
        {
            var random = new Random();

            // veri tabanındaki bütün veriyi çeker ve status degerini günceller.
            var lisOfModelExample = unitOfWork.ModelExample.GetAll();

            foreach(var modelExample in lisOfModelExample)
            {
                modelExample.Status = random.Next().ToString();

                unitOfWork.ModelExample.Update(modelExample);
            }
            unitOfWork.Complate();
        }
    }
}

