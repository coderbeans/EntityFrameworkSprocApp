using EntityFrameworkSprocApp.Data.Models;

namespace EntityFrameworkSprocApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkSprocApp.Data.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameworkSprocApp.Data.AppContext context)
        {
            // Seed the database
              context.Users.AddOrUpdate(
                p => p.Name,
                new User { Name = "Andrew Peters", Gender = Gender.Male },
                new User { Name = "Brice Lambson", Gender = Gender.Male },
                new User { Name = "Rowan Miller", Gender = Gender.Male },
                new User { Name = "Sophie Martin", Gender = Gender.Female},
                new User { Name = "Jayne Samson", Gender = Gender.Female }
              );

        }
    }
}
