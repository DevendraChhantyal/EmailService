using ApplicationToSendEmail.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationToSendEmail.Context
{
    public class AppDbConnection:DbContext
    {
        public AppDbConnection()
            : base("DefaultConnection")
        {

        }
        public DbSet<Email> Emails { get; set; }
    }
}