using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace StudentManagementSystem.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Primary Key
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FullName)
                   .HasColumnName("Name")
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.Email)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.ToTable(t => t.HasCheckConstraint(
                "CK_Student_Email",
                "[Email] LIKE '%_@_%._%'"
            ));

       
            builder.Property(s => s.Percentage)
                   .HasColumnType("decimal(4,2)");

            builder.ToTable(t => t.HasCheckConstraint(
                "CK_Student_Age",
                "[Age] >= 16"
            ));
        }
    }
}