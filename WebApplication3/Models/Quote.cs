using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public string Status { get; set; }

        public string Applicant { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EffectiveDate { get; set; }

        public string PremiumOption { get; set; }

        public int PremiumId { get; set; }

        public Premium Premium { get; set; }
    }
}