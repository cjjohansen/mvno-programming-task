using SharpArch.Domain;
using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain.Ratings;

namespace Telenor.MVNO.Domain.Consumptions
{
    /// <summary>
    /// CallRating encapsulates an algorithm used to Rate the price of a CallConsumption
    /// </summary>
    public class CallRating : Rating
    {


        public TimeSpan TimeUnitInSeconds { get; private set; }
       

        public CallRating(TimeSpan timeUnitInSeconds, Decimal unitPrice): base(unitPrice)
        {
            //Todo: add validation 
            Check.Require(timeUnitInSeconds != null, "timeUnitInSeconds cannot be null");
            Check.Require(timeUnitInSeconds.TotalSeconds != 0, "timeUnitInSeconds cannot be 0"); //It s hould really be absolute value of timeUnitInSeconds should be greater than some small number.
            TimeUnitInSeconds = timeUnitInSeconds;
        }

        public override bool CanRate(Consumption consumption)
        {
            if (consumption is CallConsumption)
                return true;
            return false;
        }


        public override decimal Rate(Consumption consumption)
        {
            CallConsumption callRecord = (CallConsumption)consumption;

            //Todo: Consider wrapping in try catch
            double units = callRecord.Duration().TotalSeconds / TimeUnitInSeconds.TotalSeconds;

            decimal price = (decimal)units * UnitPrice;

            return price;
        }
    }
}
