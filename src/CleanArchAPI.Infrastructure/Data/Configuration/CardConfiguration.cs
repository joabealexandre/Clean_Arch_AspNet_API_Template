using CleanArchAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchAPI.Infrastructure.Data.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("card");

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
