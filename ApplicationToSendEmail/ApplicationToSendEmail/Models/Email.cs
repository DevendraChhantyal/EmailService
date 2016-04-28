using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationToSendEmail.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool Status { get; set; }
        public HttpPostedFileBase Upload { get; set; }

        //[Required, Display(Name = "Your name")]
        //public string FromName { get; set; }
        //[Required, Display(Name = "Your email"), EmailAddress]
        //public string FromEmail { get; set; }
        //[Required]
        //public string Message { get; set; }
        
    }
}