using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain.Subscriptions;

namespace Telenor.MVNO.Domain.Consumptions
{
    public class DataConsumption : Consumption
    {
        public PhoneNumber CallerPhoneNumber { get; private set; }

        public Amount Amount { get; private set; }

        public DataConsumption(PhoneNumber callerNumber, Amount amount, int unitSize, DateTime dateTime, SubscriptionId subscriptionId)
            : base(unitSize, dateTime, subscriptionId)
        {
            CallerPhoneNumber = callerNumber;
            Amount = amount;
        }
    }
}
