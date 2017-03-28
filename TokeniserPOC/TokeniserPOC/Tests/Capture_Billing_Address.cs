using NUnit.Framework;
using TestStack.BDDfy;

namespace TokeniserPOC.Tests
{
    [TestFixture]
    [Story(
        AsA = "Asos Customer",
        IWant = "To be able to confirm the address regsitered against the card ",
        SoThat = "my payment passes the bank security checks (and I receive my order)"
    )]
    public class Capture_Billing_Address
    {
        [Test]
        public void Blah()
        {
            new The_Billing_Address_Is_Captured().BDDfy();
        }
    }

    public class The_Billing_Address_Is_Captured
    {
        public void Given_A_Card_Payment_Intent_With_A_Billng_Address()
        {

        }

        public void When_The_Payment_Intent_With_Billing_Address_Is_Captured()
        {

        }

        public void Then_The_Billing_Address_Is_Mandatory() 
        {

        }

        public void Then_The_First_Line_Of_The_Address_Is_Captured()
        {

        }

        public void Then_The_first_line_of_the_address_field_should_be_an_Alphanumeric_field()
        {

        }
     
        //-  The first line of the address field should be able to hold X characters
        //-  Need to capture the house name of the address that the card is registered to but this is an optional field
        //-  The house name field is an alphanumeric field
        //-  The house name field should be able to hold x characters
        //-  Need to capture the second line of the address that the card is registered to
        //-  The second line of the address field should be an Alphanumeric field
        //-  The second line of the address field should be able to hold X characters
        //-  Need to capture the third line of the address that the card is registered to
        //-  The third line of the address field should be an Alphanumeric field
        //-  The third line of the address field should be able to hold X characters
        //-  Need to capture the fourth line of the address that the card is registered to
        //-  The fourth line of the address field should be an Alphanumeric field
        //-  The fourth line of the address field should be able to hold X characters
        //-  Need to capture the fifth line of the address that the card is registered to
        //-  The fifth line of the address field should be an Alphanumeric field
        //-  The fifth line of the address field should be able to hold X characters
        //-  Need to capture the post code of the address that the card is registered to
        //-  The post code of the address field should be an Alphanumeric field
        //-  The post code of the address field should be able to hold X characters
        //-  This data is classified as PII data and should comply with all regulatory security standards
    }
}