using NUnit.Framework;
using TestStack.BDDfy;

namespace TokeniserPOC.Tests
{

    //-  On Capture of IIN/BIN check to ensure the number is not greater than 6 digits
    //-  On capture of IIN/BIN check to determine valid card scheme
    //-  On capture of PAN perform a Luhn check to determine valid PAN entry
    //-  On Capture of PAN ensure that the PAN length is not greater than 12 digits
    //-  Card number in total should not be greater than 19 digits
    //-  The field should be a number only capture
    [TestFixture]
    [Story(
        AsA = "Asos Customer",
        IWant = "To be able to validate my card number on initial capture (when using the Card Payment Option) ",
        SoThat = "(ASOS know where to obtain my funds to complete my order)",
        StoryUri = "https://asos.visualstudio.com/Backlog/_workitems?id=13941&_a=edit")]
    public class Validate_Card_Number_that_is_being_captured
    {
        private bool _actualResult;
        public string CardNumber { get; set; }

        public bool IsValid { get; set; }

        public void When_Validate_Is_Called()
        {
            var cardValidator = new CardValidator();
            _actualResult = cardValidator.Validate(CardNumber);
        }

        public void Then_The_IIN_BIN_Is_Not_Greater_Than_6_Numbers()
        {
            Assert.That(_actualResult, Is.EqualTo(IsValid));
        }

        public void The_The_Card_Scheme_Is_Valid()
        {
            Assert.That(_actualResult, Is.EqualTo(IsValid));
        }
    


        [Test]
        public void BIN_Is_Validated()
        {
            this.Given("Given I have a <CardNumber>")
                .When(_ => _.When_Validate_Is_Called())
                .Then(_ => _.Then_The_IIN_BIN_Is_Not_Greater_Than_6_Numbers())
                .And(_ => _.The_The_Card_Scheme_Is_Valid())
                .WithExamples(new ExampleTable("CardNumber", "IsValid")
                {
                    {4456123456781234, true}
                })
                .BDDfy();
        }

        [Test]
        public void Card_Scheme_Is_Valid()
        {
            this.Given("Given I have a <CardNumber>")
            .When(_ => _.When_Validate_Is_Called())
            .Then(_ => _.The_The_Card_Scheme_Is_Valid())
            .WithExamples(new ExampleTable("CardNumber", "IsValid")
            {
                    {4456123456781234, false}
            })
            .BDDfy();

        }
    }

    internal class CardValidator
    {
        public bool Validate(string cardNumber)
        {
            return false;
        }
    }

}



