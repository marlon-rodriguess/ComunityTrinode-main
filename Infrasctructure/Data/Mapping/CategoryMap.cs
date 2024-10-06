using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Table
            builder.ToTable("Categories");

            //Primary Key
            builder.HasKey(c => c.Id).HasName("PK_Categories");

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
        }
    }
}

