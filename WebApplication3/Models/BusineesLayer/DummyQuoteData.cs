using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class DummyQuoteData
    {
        private static List<Quote> quotes = new List<Quote>();
        public static List<Quote> addQuotes()
        {
            if (!(quotes.Count == 0))
            {
                return quotes;
            }
            quotes.Add(
                new Quote
                {
                    Id = 1,
                    Number = "Q92348",
                    Status = QuoteStatus.Pending.ToString(),
                    StartDate = Convert.ToDateTime("2020-07-14"),
                    EffectiveDate = Convert.ToDateTime("2020-07-20"),
                    PremiumOption = PremiumTypes.Preffered.ToString(),
                    Premium = new Premium { PremiumId = 1, Basic = 680.00, Preferred = 850.00, Premier = 1050.00 },
                    PremiumId = 1,
                    Applicant = "James Father LLC"
                });
            quotes.Add(new Quote
            {
                Id = 2,
                Number = "Q92349",
                Status = QuoteStatus.Pending.ToString(),
                StartDate = Convert.ToDateTime("2020-08-24"),
                EffectiveDate = Convert.ToDateTime("2020-11-29"),
                PremiumOption = PremiumTypes.Preffered.ToString(),
                Premium = new Premium { PremiumId = 1, Basic = 500.00, Preferred = 700.00, Premier = 1000.00 },
                PremiumId = 1,
                Applicant = "John Leather LLC 1"
            });
               quotes.Add(new Quote
               {
                   Id = 3,
                   Number = "Q92350",
                   Status = QuoteStatus.Pending.ToString(),
                   StartDate = Convert.ToDateTime("2020-11-20"),
                   EffectiveDate = Convert.ToDateTime("2020-12-30"),
                   PremiumOption = PremiumTypes.Preffered.ToString(),
                   Premium = new Premium { PremiumId = 1, Basic = 700.00, Preferred = 900.00, Premier = 2000.00 },
                   PremiumId = 1,
                   Applicant = "John Leather LLC 2"
               });


            return quotes;
        }
    }
}