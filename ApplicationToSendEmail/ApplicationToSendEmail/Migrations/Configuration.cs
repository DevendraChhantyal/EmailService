namespace ApplicationToSendEmail.Migrations
{
    using ApplicationToSendEmail.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationToSendEmail.Context.AppDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationToSendEmail.Context.AppDbConnection context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
              List<Email>eList=new List<Email>()
            {
                new Email()
                {
                    FirstName="Ram",LastName="Baral",EmailAddress="iamram515@gmail.com",Status=true
                },

                new Email()
                {
                    FirstName="Devendra",LastName="Chhantyal",EmailAddress="chhantyal.devan@gmail.com",Status=true
                },
                new Email()
                {
                    FirstName="Suman",LastName="Heuju",EmailAddress="sumanheuju2@gmail.com",Status=true
                },
                new Email()
                {
                    FirstName="Naran",LastName="Thapa",EmailAddress="thapanaran@gmail.com",Status=false
                }
                };
               eList.ForEach(e=>
                   {
                       context.Emails.Add(e);
                       context.SaveChanges();
                   });
            }
        }
    }


