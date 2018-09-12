using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain.Subscriptions;

namespace Telenor.MVNO.Domain.Consumptions
{
    public class SMSConsumption : Consumption
    {

        private const int ConsumptionUnitSize = 1;

        public PhoneNumber CallerPhoneNumber { get; private set; }
        public PhoneNumber ReceiverPhoneNumber { get; private set; }

        public Boolean IsCrossCountryZone { get; private set; }
        public SMSConsumption(PhoneNumber callerNumber, PhoneNumber receiverNumber, DateTime dateTime, Boolean isCrossCountryZone, SubscriptionId subscriptionId)
            : base(ConsumptionUnitSize, dateTime, subscriptionId)
        {
            CallerPhoneNumber = callerNumber;
            ReceiverPhoneNumber = receiverNumber;
            IsCrossCountryZone = isCrossCountryZone;
        }
    }
}
