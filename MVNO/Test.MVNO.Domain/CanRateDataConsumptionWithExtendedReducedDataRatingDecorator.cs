using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.MVNO.Domain.Consumptions;
using Telenor.MVNO.Domain.Ratings;
using Telenor.MVNO.Domain.Subscriptions;
using Xunit;

namespace MVNO.Domain.Tests
{
    public class CanRateDataConcumptionWithReducedDataDataRating
    {
        [Fact]
        public void ShouldRateDataConsumptionWithReducedDataRating()
        {
            //Arrange
            //TODO: avoid code duplication in tests
            decimal reductionFactor = (decimal)0.5;
            var callerNumber = new PhoneNumber("4530131514");
            var receiverNumber = new PhoneNumber("4530202020");
            var startTime = new DateTime(2014, 1, 9, 21, 10, 10);
            var endTime = new DateTime(2014, 1, 9, 21, 20, 20);
            var subscriptionId = new SubscriptionId(new Guid("b8e5bae2-76e7-49a8-b5ae-2cd0eb229b16"));
            var dataConsumption = new DataConsumption(callerNumber, new Amount(30.0, Unit.MB), 1, startTime, subscriptionId);
            var reducedDataRating = new ReducedDataRatingDecorator(new DataRating((decimal)3), reductionFactor);

            //Act
            var result = reducedDataRating.Rate(dataConsumption);



            //Assert
            Assert.Equal(30 * 3 * reductionFactor, result);
        }
    }
}
