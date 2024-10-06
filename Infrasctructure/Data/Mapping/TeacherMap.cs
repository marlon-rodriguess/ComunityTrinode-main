using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data.Mapping
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            //Table
            builder.ToTable("Teachers");

            //Primary Key
            builder.HasKey(t => t.Id).HasName("PK_Teachers");

            //Properties
            builder.Property(t => t.Id)
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
            
            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(t => t.HashPassword)
                .HasColumnName("Password")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(t => t.Salt)
                .HasColumnName("Salt")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(t => t.CPF)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(11);
            
            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(11);
            
            builder.Property(t => t.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(t => t.CEP)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(8);
            
            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(t => t.ImageUrl)
                .HasColumnName("ImageUrl")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            //Relationships
            builder.HasMany(t => t.Courses)
                .WithMany(c => c.Teachers);
        }
    }
}

