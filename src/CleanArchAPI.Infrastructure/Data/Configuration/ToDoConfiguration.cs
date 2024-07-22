using CleanArchAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchAPI.Infrastructure.Data.Configuration
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder.ToTable("to_do");

            builder.HasKey(p => p.Id)
                .HasName("id_pkey");

            builder.Property(p => p.Id)
                .HasColumnName("id");

            builder.Property(p => p.Title)
                .HasColumnName("title")
                .HasMaxLength(200);

            builder.Property(p => p.Title)
                .HasColumnName("description")
                .HasColumnType("text");
        }
    }
}
