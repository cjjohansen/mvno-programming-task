using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain.Subscriptions;
using Telenor.MVNO.Domain.Common;

namespace Telenor.MVNO.Domain.Consumptions
{
    public abstract class Consumption : ValueObjectWithPersistenceId<Guid>
    {

        public int UnitSize { get; private set; }
        
        [DomainSignature]
        public DateTime Date { get; private set; }

        [DomainSignature]
        public SubscriptionId SubscriptionId { get; private set; }
    
        public Consumption(int unitSize, DateTime date, SubscriptionId subscriptionId)
        {
            UnitSize = unitSize;
            Date = date;
            SubscriptionId = subscriptionId;
        }
    }
}
