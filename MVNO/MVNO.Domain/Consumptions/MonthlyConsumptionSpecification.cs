using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpArch.Domain.Specifications;
using Telenor.MVNO.Domain.Subscriptions;
using Telenor.MVNO.Domain.Common.Extensions;
using System.Linq.Expressions;

namespace Telenor.MVNO.Domain.Consumptions
{
    /// <summary>
    /// Query that returns the consumptions within a given month and year for a subscription
    /// </summary>
    public class MonthlyConsumptionQuery : QuerySpecification<Consumption>
    {

        public int Month { get; private set; }
        public int Year { get; private set; }
        public SubscriptionId SubscriptionId { get; private set; }

        /// <summary>
        /// force developers to not use  parameterless constructor
        /// </summary>
        protected MonthlyConsumptionQuery()
        {

        }

        public MonthlyConsumptionQuery(SubscriptionId subscriptionId, int year, int month)
        {
            SubscriptionId = subscriptionId;
            Year = year; //Todo: validate year
            Month = month; //TODO: validate month  is beteen 1 and 12
        }


        public override Expression<Func<Consumption, bool>> MatchingCriteria
        {
            get { return x => x.SubscriptionId == SubscriptionId && x.Date.IsWithIn(Year, Month); }
        }
     
    }
}
