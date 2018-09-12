using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telenor.MVNO.Domain;
using Xunit;
using FluentAssertions;
using Telenor.MVNO.Domain.Consumptions;

namespace Telenor.MVNO.Web.Domain.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void ShouldConstruct()
        {
            //Arrange
            var phoneNumberAsString = "4530131514";
            //Act
            var phoneNumber = new PhoneNumber(phoneNumberAsString);
            //Assert
            Assert.NotNull(phoneNumber);
            phoneNumber.Number.ShouldBeEquivalentTo<String>(phoneNumberAsString);
        }

    }
}
