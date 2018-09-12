using System;
using TechTalk.SpecFlow;
using Telenor.MVNO.Domain.Consumptions;
using Telenor.MVNO.Domain.Ratings;
using Telenor.MVNO.Domain.Subscriptions;
using Xunit;

namespace Telenor.MVNO.Web.Specs
{
    [Binding]
    public class RateCallConsumptionSteps
    {
        private CallConsumption _callConsumption;
        private Subscription _subscription;
        private Decimal _ratingResult;
        private SubscriptionId _subscriptionId = new SubscriptionId(new Guid("05a4120c-8cce-4425-9023-4ea49c94456d"));

        [Given]
        public void Given_I_have_a_CallConsumption_with_a_duration_of_X_seconds(int x)
        {
            var startTime = new DateTime(2014, 1, 9, 21, 10, 0);
            var endTime = startTime.AddSeconds(x);
            var isCrossCountry = false;
            var callerNumber = new PhoneNumber("4530131514");
            var receiverNumber = new PhoneNumber("4570103013");
            int unitSize = 1;

            _callConsumption = new CallConsumption(callerNumber, receiverNumber, startTime, endTime, isCrossCountry, unitSize, _subscriptionId);
            //TODO: We could use the fluent builder pattern to make construction more readable.
        }


        [Given]
        public void Given_I_have_a_CallRating_with_a_unitSize_of_UNITSIZE_seconds_and_a_unitprice_of_UNITPRICE_kr_pr_minute(int unitSize, Decimal unitPrice)
        {
            var subscriber = new Subscriber(new SubscriberId(1), new PersonName("John", "Doe"));
            _subscription = new Subscription(_subscriptionId, subscriber,
                                         SubscriptionType.Standard,
                                         new CallRating(new TimeSpan(0, 0, unitSize), unitPrice),
                                         new SMSRating((decimal)0.10), //TODO: introduce local variable to make it readable what number represent
                                         new DataRating((decimal)0.05)
                                         );
        }


      
        [When]
        public void When_The_rating_is_triggered()
        {
            _ratingResult = _subscription.CallRating.Rate(_callConsumption);
        }


        [Then]
        public void Then_the_rating_result_should_be_EXPECTEDRATINGRESULT_kr(Decimal expectedRatingResult)
        {
            Assert.Equal(expectedRatingResult, _ratingResult, 4);
        }
    }
}
