using SharpArch.Domain.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telenor.MVNO.Domain.Consumptions;

namespace Telenor.MVNO.Domain.Ratings
{
    public abstract class Rating : ValueObject
    {
        public int ConsumptionUnitSize { get; private set; }
        public Decimal UnitPrice { get; private set; }
        public abstract Decimal Rate(Consumption consumption);


        public abstract bool CanRate(Consumption consumption);

        private Rating()
        {

        }

        public Rating(Decimal unitPrice)
        {
            UnitPrice = unitPrice;
        }
    }
}
