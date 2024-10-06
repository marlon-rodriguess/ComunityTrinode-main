using Microsoft.EntityFrameworkCore;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data
{
    public class TrinodeDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DB_Trinode;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Mapping.CourseMap());
            modelBuilder.ApplyConfiguration(new Mapping.UserMap());
            modelBuilder.ApplyConfiguration(new Mapping.ModuleMap());
            modelBuilder.ApplyConfiguration(new Mapping.TeacherMap());
            modelBuilder.ApplyConfiguration(new Mapping.LectureMap());
        }
    }
}

