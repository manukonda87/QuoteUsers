using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class UserQuoteViewModel
    {
        public User user { get; set; }
        public Quote quote { get; set; }

        public bool IsExistingUser { get; set; }
    }
}