using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StubUnitTesting;
namespace UnitTestingUsingStub
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Testingpayment()
        {
            //Arrange
            var paymentgatewaystub = new PaymentGatewayStub();
            var paymentprocessor = new PaymentProcessor(paymentgatewaystub);

            //Act
            var result = paymentprocessor.MakePayment(100.0m);

            //Assert
            Assert.That(result, Is.EqualTo(true));
        }
    }
}
