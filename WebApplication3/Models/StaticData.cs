using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public enum QuoteStatus
    {
        Pending = 1,
        Issued
    }

    public enum PremiumTypes
    {
        Basic = 1,
        Preffered,
        Premier
    }

    public enum Gender
    {
        Male,
        FeMale
    }
}