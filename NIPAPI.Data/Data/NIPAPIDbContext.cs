using Microsoft.EntityFrameworkCore;
using NIPAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Data.Data
{
    public class NIPAPIDbContext : DbContext
    {
        public NIPAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Title = "Chemistry",
                    Description = "Chemical reaction",
                    Teacher= "Mr Ben",
                    Rating= 4.5
                },
                new Course
                {
                    Id= 2,
                    Title= "Physics",
                    Description= "Physical reaction",
                    Teacher="Mrs Joy",
                    Rating= 4.3
                },
                new Course
                {
                    Id=3,
                    Title= "Agile",
                    Description= "Agile methodology",
                    Teacher= "Mr Steve",
                    Rating= 4.0
                }
                );
            modelBuilder.Entity<Registration>().HasData(
                new Registration
                {
                    Id = 1,
                    CourseId = 1,
                    UserId = 1,
                    Date = DateTime.UtcNow

                },
                new Registration
                {
                    Id=2,
                    CourseId = 2,
                    UserId = 2,
                    Date = DateTime.UtcNow
                },
                new Registration
                {
                    Id=3,
                    CourseId = 3,
                    UserId = 3,
                    Date = DateTime.UtcNow
                }
                );
        }
    }
}
