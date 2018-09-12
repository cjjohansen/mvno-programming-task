using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain;
using Telenor.MVNO.Domain.Ratings;

namespace Telenor.MVNO.Domain.Subscriptions
{
    /// <summary>
    /// Represents the concept of a subscription who's responsibility it is to hold information of what rules are used to
    /// calculate prices for Calls, SMS's and DataTransfers.
    /// </summary>
    public class Subscription : EntityWithTypedId<Guid>
    {
        [DomainSignature]
        public SubscriptionId SubscriptionId { get; private set; }
        public Subscriber  Subscriber { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public Rating CallRating { get; set; }
        public Rating SMSRating { get; set; }
        public Rating DataRating { get; set; }


        public Subscription(SubscriptionId subscriptionId, Subscriber subscriber, SubscriptionType subscriptionType, Rating callRating, Rating smsRating, Rating dataRating)
        {
            SubscriptionId = subscriptionId;
            Subscriber = subscriber;
            SubscriptionType = subscriptionType;
            CallRating = callRating;
            SMSRating = smsRating;
            DataRating = dataRating;
        }

    }
}
