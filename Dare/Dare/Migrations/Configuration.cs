namespace Dare.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dare.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Dare.Models.ApplicationDbContext context)
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
            //context.Roles.AddOrUpdate(r => r.Name,
            //    new IdentityRole { Name = "Admin" },
            //    new IdentityRole { Name = "User" }
            //    );

            //var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //string[] roleNames = { "Admin", "User" };
            //IdentityResult roleResult;
            //foreach (var roleName in roleNames)
            //{
            //    if (!RoleManager.RoleExists(roleName))
            //    {
            //        roleResult = RoleManager.Create(new IdentityRole(roleName));
            //    }

            //}
            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //UserManager.AddToRole("bf24df57-cf59-4122-9461-4f69fadfc277", "Admin");



        }

    }
}