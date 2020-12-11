using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ManageQuote : IManageQuote
    {
        public Quote GetQuote(int quoteid)
        {
            Quote quote = DummyQuoteData.addQuotes().Where(q => q.Id == quoteid).SingleOrDefault();
            return quote;
        }
    }
}