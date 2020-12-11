using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class QuoteUser
    {
        public int Id { get; set; }
        public int QuoteId { get; set; }

        public int UserId { get; set; }
    }
}