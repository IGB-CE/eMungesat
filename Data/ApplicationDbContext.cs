using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eMungesat.Data.Models;

namespace eMungesat.Models
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<SchedulerEvent> Events { get; set; }
        public DbSet<SchedulerResource> Resources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 1, Name = "Resource A" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 2, Name = "Resource B" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 3, Name = "Resource C" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 4, Name = "Resource D" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 5, Name = "Resource E" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 6, Name = "Resource F" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 7, Name = "Resource G" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 8, Name = "Resource H" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 9, Name = "Resource I" });
            modelBuilder.Entity<SchedulerResource>().HasData(new SchedulerResource { Id = 10, Name = "Resource J" });

        }
    }
}
