using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;

namespace Telenor.MVNO.Web
{
    public class MonthlyConsumptionViewModel
    {
        public MonthlyConsumptionViewModel()
        {
           
        }


        public string Date { get; set; }


        public IEnumerable<ConsumptionGroupViewModel> ConsumptionGroups { get; set; }

        public string TotalPrice { get; set; }
       

        public string Currency { get; set; }
    }
}
