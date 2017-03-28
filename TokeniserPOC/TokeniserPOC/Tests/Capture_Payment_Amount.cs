using NUnit.Framework;
using TestStack.BDDfy;

namespace TokeniserPOC.Tests
{
    [TestFixture]
    [Story(
        AsA = "Cashier",
        IWant = "To know the value of the order ",
        SoThat = "I Know how much to charge the customer"
    )]
    public class Capture_Payment_Amount
    {
        [Test]
        public void Blah()
        {
            new The_Payment_Amount_Is_Captured().BDDfy();
        }
    }

    public class The_Payment_Amount_Is_Captured
    {
        public void Given_A_Card_Payment_Intent()
        {

        }

        public void When_The_Payment_Intent_Is_Captured()
        {

        }


        public void Then_The_Value_Of_The_Order_Should_Be_Numerical()
        {

        }

        public void And_The_Field_Length_Should_Be_No_Longer_Than_X_Characters()
        {

        }

        public void And_Then_Currency_Of_The_Order_Should_Be_Captured()
        {

        }

        public void And_The_Currency_Should_Be_Restricted_To_2_Decimal_Placess()
        {

        }
    }
}