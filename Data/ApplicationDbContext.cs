using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eMungesat.Data.Models;
using Microsoft.Extensions.Hosting;

namespace eMungesat.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<SchedulerEvent> Events { get; set; }
        public DbSet<SchedulerResource> Resources { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Curriculum> Curricula { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Report> Reports { get; set; }

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


            modelBuilder.Entity<Course>()
                .HasMany(c => c.StudentGroups)
                .WithMany(s => s.Courses)
                .UsingEntity<CourseGroup>();

            modelBuilder.Entity<CourseGroup>()
                .HasOne(cg => cg.StudentGroup)
                .WithMany(sg => sg.CourseGroups)
                .HasForeignKey(cg => cg.StudentGroupId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict or NoAction to break the cascade path
            modelBuilder.Entity<CourseGroup>()
                .HasOne(cg => cg.Course)
                .WithMany(c => c.CourseGroups)
                .HasForeignKey(c => c.StudentGroupId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict or NoAction to break the cascade path

        }
    }
}
