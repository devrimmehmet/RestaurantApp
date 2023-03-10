using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RestaurantApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }
        public DbSet<RestaurantApp.Models.Home> Home { get; set; }
        public DbSet<RestaurantApp.Models.About> About { get; set; }
        public DbSet<RestaurantApp.Models.Service> Service { get; set; }
        public DbSet<RestaurantApp.Models.Email> Email { get; set; }
        public DbSet<RestaurantApp.Models.Message> Message { get; set; }
        public DbSet<RestaurantApp.Models.Slider> Slider { get; set; }
        public DbSet<RestaurantApp.Models.WebsiteInfo> WebsiteInfo { get; set; }
        public DbSet<RestaurantApp.Models.ProductMainCategory> ProductMainCategory { get; set; }
        public DbSet<RestaurantApp.Models.ProductCategory> ProductCategory { get; set; }
        public DbSet<RestaurantApp.Models.ProductSubCategory> ProductSubCategory { get; set; }
        public DbSet<RestaurantApp.Models.Product> Product { get; set; }


    }
}