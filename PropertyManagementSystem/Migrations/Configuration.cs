using System.Linq;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyDbContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.
			using (var db = new MyDbContext())
			{
				if (!db.Users.Any())
				{
					db.Users.Add(new User { FullName = "Administrator", IsActive = true, Password = "admin@123", UserName = "admin", UserType = UserType.Administrator});
					db.SaveChanges();
				}
			}
        }
    }
}
