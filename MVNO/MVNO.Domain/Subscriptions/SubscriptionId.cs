using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.MVNO.Domain.Subscriptions
{
    public class SubscriptionId : ValueObject
    {

        public Guid Id { get; private set; }

        public SubscriptionId(Guid id )
        {
            Id = id;
        }
    }
}
