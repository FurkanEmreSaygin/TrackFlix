using Microsoft.EntityFrameworkCore;
using Trackflix.Entities.entities;

namespace Trackflix.DataAccess
{
    public class AppDbContext : DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<UserSeries> UserSeries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User-Role: One(Role) - Many(Users)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserSeries composite key (many-to-many explicit)
            modelBuilder.Entity<UserSeries>()
                .HasKey(us => new { us.UserId, us.SeriesId });

            modelBuilder.Entity<UserSeries>()
                .HasOne(us => us.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(us => us.UserId);

            modelBuilder.Entity<UserSeries>()
                .HasOne(us => us.Series)
                .WithMany(s => s.UserFavorites)
                .HasForeignKey(us => us.SeriesId);

            // Basit seed: Roller
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Admin" },
                new Role { Id = 2, RoleName = "User" }
            );
        }
    } 
}