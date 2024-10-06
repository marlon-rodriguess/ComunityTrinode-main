using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data.Mapping
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            //Table
            builder.ToTable("Courses");

            //Primary Key
            builder.HasKey(c => c.Id).HasName("PK_Courses");

            //Properties
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier")
                .IsRequired().ValueGeneratedOnAdd();
            
            builder.Property(c => c.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("DATETIME")
                .IsRequired();
            
            builder.Property(c => c.UpdatedDate)
                .HasColumnName("UpdatedDate")
                .HasColumnType("DATETIME")
                .IsRequired();
            
            builder.Property(c => c.DeletedDate)
                .HasColumnName("DeletedDate")
                .HasColumnType("DATETIME");
            
            builder.Property(c => c.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(c => c.Description)
                .HasColumnName("Description")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(c => c.ImageUrl)
                .HasColumnName("ImageUrl")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(c => c.Price)
                .HasColumnName("Price")
                .HasColumnType("FLOAT")
                .IsRequired();
            
            builder.Property(c => c.Category)
                .HasColumnName("Category")
                .HasColumnType("VARCHAR");

            builder.Property(c => c.Technology)
                .HasColumnName("Technology")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(50);
            
            builder.Property(c => c.TotalHours)
                .HasColumnName("TotalHours")
                .HasColumnType("FLOAT")
                .IsRequired();

            //Relationships
            builder.HasMany(c => c.Modules)
                .WithOne(m => m.Course)
                .HasForeignKey("FK_Courses_Modules")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Users)
                .WithMany(u => u.Courses)
                .UsingEntity(j => j.ToTable("UserCourses"));
            
            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey("Category")
                .HasConstraintName("FK_Course_Category");

              builder
                .HasMany(x => x.Teachers)
                .WithMany(x => x.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "TeacherCourse",
                    teacher => teacher
                        .HasOne<Teacher>()
                        .WithMany()
                        .HasForeignKey("Courses")
                        .HasConstraintName("FK_Teacher_CourseId")
                        .OnDelete(DeleteBehavior.Cascade),
                    course => course
                        .HasOne<Course>()
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Course_TeacherId")
                        .OnDelete(DeleteBehavior.Cascade));
        }
    }
}

