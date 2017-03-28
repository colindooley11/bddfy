using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Newtonsoft.Json;
using NUnit.Framework;
using TestStack.BDDfy;
using TokeniserPOC.Controllers;

namespace TokeniserPOC.Tests
{
    [TestFixture]
    [Story(
        AsA = "Checkout client",
        IWant = "I want to be able to capture a card payment request with sensitive data which is then handled securely",
        SoThat = "Customers card holder data is protected whilst using Card Payment"
    )]
    public class Card_Capture_Story
    {
        [Test]
        public void Card_Is_Captured()
        {
            new Card_Is_Captured().BDDfy();
        }
    }

    public class Card_Is_Captured
    {
        private HttpResponseMessage result;
        private HttpResponseMessage _httpResponseMessage;

        public void Given_A_Request()
        {
            var controller = new CardController();
            controller.Request = new HttpRequestMessage();
            controller.ControllerContext.Configuration = new HttpConfiguration();
            this.result = controller.Put(new CardDetails() { CardNumber = "4111111111111111" }).ExecuteAsync(new CancellationToken()).Result;
        }

        public void Then_The_Card_Holder_Details_Are_Saved()
        {
            Assert.That(this.result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        public void And_Then_The_Card_Holder_Details_Are_Now_PII()
        {
            var result = JsonConvert.DeserializeObject<CardCaptureResults>(this.result.Content.ReadAsStringAsync().Result);
            Assert.That(result.CardNumberFirstSixLastFour, Is.EqualTo("411111******1111"));
        }
    }
}