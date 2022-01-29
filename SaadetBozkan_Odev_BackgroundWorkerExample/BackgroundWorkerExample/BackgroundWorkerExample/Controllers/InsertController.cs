using BackgroundWorkerExample.Jobs;
using Data.DataModel;
using Data.Uow;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackgroundWorkerExample.Controllers
{
    [Route("/")]
    [ApiController]
     public class InsertController : ControllerBase
     {
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<InsertController> logger;


        public InsertController(ILogger<InsertController> logger, IUnitOfWork unitOfWork)
        {
            this.logger = logger;

            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public string Get()
        {
            BWRecurringJob recurringJob = new BWRecurringJob(unitOfWork);            
            return "Hello";
        }
     }
}
