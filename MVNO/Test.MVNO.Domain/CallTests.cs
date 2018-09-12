using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.MVNO.Domain;
using Xunit;
using FluentAssertions;
using Telenor.MVNO.Domain.Consumptions;
using Telenor.MVNO.Domain.Subscriptions;

namespace Telenor.MVNO.Web.Domain.Tests
{
    public class CallTests
    {
        [Fact]
        public void ShouldConstruct()
        {
            //Arrange

            var callerNumber = new PhoneNumber("4530131514");
             var receiverNumber = new PhoneNumber("4530202020");
            var startTime = new DateTime(2014,1,9,21,10,10);
            var endTime = new DateTime(2014,1,9,21,20,20);
            var subscriptionId = new SubscriptionId(new Guid("b8e5bae2-76e7-49a8-b5ae-2cd0eb229b16"));

            Caller caller = new Caller();

            //Act
            Consumption sut = new CallConsumption(callerNumber, receiverNumber, startTime, endTime, false, 1, subscriptionId);

            //Assert
            Assert.NotNull(sut);


        }
    }
}
