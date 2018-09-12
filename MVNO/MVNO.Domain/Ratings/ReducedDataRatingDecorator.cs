using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.MVNO.Domain.Ratings
{
    /// <summary>
    /// ReducedDataRatingDecorator Shows a contireved example in how to extend an exsisting Rating with an added operation/behavior
    /// Im not sure about the naming. Some folks don't like appending designpattern names on classes.
    /// </summary>
    public class ReducedDataRatingDecorator : RatingDecorator 
    {
        public  decimal ReductionFactor { get; private set; }

        public ReducedDataRatingDecorator(Rating decoratee, decimal reductionFactor ) : base(decoratee)
        {
            ReductionFactor = reductionFactor;
        }

        public override decimal Rate(Consumptions.Consumption consumption)
        {
            return RatingDecoratee.Rate(consumption) * ReductionFactor;
        }
    }
}
