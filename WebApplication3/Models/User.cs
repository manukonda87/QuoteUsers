using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        //[RegularExpression("(?:\b|-)([1-9]{1,2}[0]?|100)\b", ErrorMessage = "Invalid Coverage value")]
        public int Coverage { get; set; }
    }
}