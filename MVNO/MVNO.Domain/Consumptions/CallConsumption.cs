using SharpArch.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain;
using Telenor.MVNO.Domain.Subscriptions;

namespace Telenor.MVNO.Domain.Consumptions
{
    /// <summary>
    /// Immutable record of a call made in the past.
    /// </summary>
    public class CallConsumption :Consumption
    {
        /// <summary>
        /// Constructor ensures that a CallRecord can only be in a valid state
        /// </summary>
        /// <param name="callerNumber"></param>
        /// <param name="receiverNumber"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="isCrossCountryZone"></param>
        public CallConsumption(PhoneNumber callerNumber, PhoneNumber receiverNumber, DateTime startTime, DateTime endTime, bool isCrossCountryZone, int unitSize, SubscriptionId subscriptionId): base(unitSize, startTime, subscriptionId)
        {
            //Todo: One could check for null for all input paremeters;
            StartTime = startTime;
            EndTime = endTime;
            Check.Require(StartTime < EndTime,"StartTime has to be less than EndTime");
            CallerPhoneNumber = callerNumber;
            ReceiverPhoneNumber = receiverNumber;
            IsCrossCountryZone = isCrossCountryZone;
        }

        public TimeSpan Duration()
        {
            return EndTime.Subtract(StartTime);
        }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public PhoneNumber CallerPhoneNumber { get; private set; }
        public PhoneNumber ReceiverPhoneNumber { get; private set; }

        public Boolean IsCrossCountryZone { get; private set; }
    }
}
