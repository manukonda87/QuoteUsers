﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication3.Models
{
    interface IManageQuote
    {
        Quote GetQuote(int id);
    }
}
