// Data/ApplicationDbContext.cs
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserData> UserDatas { get; set; }

        // Add or modify this method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Ensure base configurations are applied

            // Configure the BankBalance property for the UserData entity
            builder.Entity<UserData>()
                .Property(ud => ud.BankBalance)
                .HasPrecision(18, 2); // Specify precision (18) and scale (2)
        }
    }
}