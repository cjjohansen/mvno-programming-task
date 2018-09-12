using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telenor.MVNO.Domain.Ratings
{
    public abstract class RatingDecorator : Rating
    {
        public Rating RatingDecoratee { get; set; }

        public RatingDecorator(Rating decoratee) : base(decoratee.ConsumptionUnitSize)
        {
            RatingDecoratee = decoratee;
        }

        public override bool CanRate(Consumptions.Consumption consumption)
        {
            return RatingDecoratee.CanRate(consumption);
        }

    }
}
