using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data.Mapping
{
    public class ModuleMap : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            //Table
            builder.ToTable("Modules");

            //Primary Key
            builder.HasKey(t => t.Id).HasName("PK_Modules");

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
            
            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(x => x.Lectures)
                .HasColumnName("Lectures")
                .HasColumnType("INT");
        }
    }
}

