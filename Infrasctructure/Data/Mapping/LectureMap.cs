using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trinode.Domain.Entities;

namespace Trinode.Infrastructure.Data.Mapping
{
    public class LectureMap : IEntityTypeConfiguration<Lecture>
    {
        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            //Table
            builder.ToTable("Lectures");

            //Primary Key
            builder.HasKey(l => l.Id).HasName("PK_Lectures");

            //Properties
            builder.Property(l => l.Id)
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
            
            builder.Property(l => l.Name)
                .HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(100);
            
            builder.Property(l => l.VideoUrl)
                .HasColumnName("VideoUrl")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(x => x.GithubUrl)
                .HasColumnName("GithubUrl")
                .HasColumnType("VARCHAR")
                .IsRequired().HasMaxLength(255);
            
            builder.Property(x => x.ModuleGuid)
                .HasColumnName("ModuleGuid")
                .HasColumnType("uniqueidentifier")
                .IsRequired();
        }
    }
}

