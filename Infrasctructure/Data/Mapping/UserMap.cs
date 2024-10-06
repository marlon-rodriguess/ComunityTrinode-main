using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Table 
            builder.ToTable("Users");

            //Primary Key
            builder.HasKey(u => u.Id).HasName("PK_Users");

            //Properties
            builder.Property(u => u.Id)
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
            
            builder.Property(u => u.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(u => u.HashPassword)
                .HasColumnName("Password")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(u => u.Salt)
                .HasColumnName("Salt")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(u => u.CPF)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(11);
            
            builder.Property(u => u.Phone)
                .HasColumnName("Phone")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(11);
            
            builder.Property(u => u.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(u => u.CEP)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(8);
            
            //Relationships
            builder
                .HasMany(x => x.Courses)
                .WithMany(x => x.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    course => course
                        .HasOne<Course>()
                        .WithMany()
                        .HasForeignKey("Courses")
                        .HasConstraintName("FK_UserRole_CourseId")
                        .OnDelete(DeleteBehavior.Cascade),
                    user => user
                        .HasOne<User>()
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserRole_UserId")
                        .OnDelete(DeleteBehavior.Cascade));
        }
    }
}

