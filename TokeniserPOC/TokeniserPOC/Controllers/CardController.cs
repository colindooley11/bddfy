using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TokeniserPOC.Controllers;

namespace TokeniserPOC.Controllers
{
    public class CardController : ApiController
    {

        public IHttpActionResult Put(CardDetails cardDetails)
        {
            CardCaptureResults results = new CardCaptureResults();
            GetFirstSixLastFour(cardDetails, results);
            return Ok(results); 
        }

        private static void GetFirstSixLastFour(CardDetails cardDetails, CardCaptureResults results)
        {
            var firstSix = cardDetails.CardNumber.Substring(0, 6);
            var lastFour = cardDetails.CardNumber.Substring(cardDetails.CardNumber.Length - 4, 4);
            var middleBit = new string('*', cardDetails.CardNumber.Length - 10);
            results.CardNumberFirstSixLastFour = firstSix + middleBit + lastFour;
        }


    }

    public class CardDetails
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public string ExpiryDate { get; set; }
    }


    public class CardCaptureResults
    {
        public string CardNumberFirstSixLastFour{ get; set; }
    }
}