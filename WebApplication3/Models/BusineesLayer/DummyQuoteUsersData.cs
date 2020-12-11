using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class DummyQuoteUsersData
    {
        public static List<QuoteUser> quoteUsers = new List<QuoteUser>();
       

        public static List<QuoteUser> addQuoteUsers()
        {
            if(!(quoteUsers.Count == 0))
            {
                return quoteUsers;
            }
            quoteUsers.Add(
                new QuoteUser
                {
                    Id = 1,
                    QuoteId = 1,
                    UserId = 1
                });
            quoteUsers.Add(
                new QuoteUser
                {
                    Id = 2,
                    QuoteId = 1,
                    UserId = 2
                });
            quoteUsers.Add(
                new QuoteUser
                {
                    Id = 3,
                    QuoteId = 1,
                    UserId = 3
                });
            return quoteUsers;
        }
    }
}