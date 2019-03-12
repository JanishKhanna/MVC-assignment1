namespace InclassAssignment1.Migrations
{
    using InclassAssignment1.Models;
    using InclassAssignment1.Models.Domain;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InclassAssignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(InclassAssignment1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var user1 = new ApplicationUser();
            user1.FirstName = "John";
            user1.LastName = "Doe";
            user1.Email = "johndoe@test.com";
            user1.PasswordHash = "Password - 1";

           

            var user2 = new ApplicationUser();
            user2.FirstName = "Jane";
            user2.LastName = "Doe";
            user2.Email = "janedoe@test.com";
            user2.PasswordHash = "Password - 1";

            
            var course1 = new Course();
            course1.Name = "Software Developer";
            course1.NumberOfHours = 330;

            var course2 = new Course();
            course2.Name = "Cyber Defense";
            course2.NumberOfHours = 340;

            var userManager =
               new UserManager<ApplicationUser>(
                       new UserStore<ApplicationUser>(context));

            
        }
    }
}
