using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.MVNO.Domain.Consumptions;

namespace Telenor.MVNO.Domain.Ratings
{
    /// <summary>
    /// Assigns a fixed price for the record.
    /// </summary>
    public class SMSRating : Rating
    {
        public SMSRating(decimal unitPrice): base(unitPrice)
        {

        }

        public override bool CanRate(Consumption consumption)
        {
            if (consumption is SMSConsumption)
                return true;
            return false;
        }

        public override decimal Rate(Consumption consumption)
        {
            return UnitPrice;
        }
    }
}
