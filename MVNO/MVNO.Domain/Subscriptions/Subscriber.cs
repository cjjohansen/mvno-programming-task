using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telenor.MVNO.Domain.Subscriptions
{
    public class Subscriber : EntityWithTypedId<Guid>
    {
        [DomainSignature]
        public SubscriberId SubscriberId { get; private set; }
        
        public PersonName Name { get; set; }

        public Subscriber(SubscriberId id, PersonName name)
        {
            SubscriberId = id;
            Name = name;
        }
    }
}
