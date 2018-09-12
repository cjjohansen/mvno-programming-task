using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telenor.MVNO.Domain.Subscriptions
{
    public class SubscriberId : ValueObject
    {
        public int Id { get; private set; }

        public SubscriberId(int id)
        {
            Id = id;
        }

    }
}
