using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telenor.MVNO.Domain.Consumptions;

namespace Telenor.MVNO.Web.Controllers
{
    public class ConsumptionController : Controller
    {

        private IConsumptionRepository _consumptionRepository;
        public ConsumptionController()
        {

        }

        public ConsumptionController(IConsumptionRepository consumptionRepository)
        {
            _consumptionRepository = consumptionRepository;
        }



        //
        // GET: /Consumption/

        public ActionResult Index()
        {

            //TODO: Get Subscriber by SubscriberId

            //TODO: Get Subscription for Subscriber (Assuming Subscriber only has one subscription)
            //The subscription could pull all Consumptions into memory,
            //so grouping and paging by month could be done clientSide.
            //It depends on the usage scenario. Another strategy is to only load a subset of consumptions based on a query.

            //TODO: Query Consumptions by Subscription and month.

        //   IQueryable<Consumption> consumptions =  _consumptionRepository.FindAll();

            //TODO: If no Optimized view has been stored in the Database (using a CQRS strategy) We need to Create a ViewModel from the loaded consumptions.

            //I Don't care so much about encapsulation for a ViewModel; so i just let the properties have public getters and setters
            //For Domain classes i would avoid public setters as much as possible.
            
            
            
            
            var monthlyConsumptionViewModel = new MonthlyConsumptionViewModel()
            {
                Currency = "kr",
                Date="January 2014",
                TotalPrice="1000"


            };







            return View(monthlyConsumptionViewModel);
        }

    }
}
