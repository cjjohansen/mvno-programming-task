using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Telenor.MVNO.Web
{
    public class ConsumptionGroupViewModel
    {
        public ConsumptionGroupViewModel()
        {
           
        }

        public string Title { get; set; }

        public string ConsumptionEntryCount { get; set; }

        public string UnitPrice { get; set; }

        public string ConsumptionType { get; set; }

        public string TotalConsumption { get; set; }

        public string TotalPrice { get; set; }

        public string Currency { get; set; }
    }
}
