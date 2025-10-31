using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100);
            builder.Property(c => c.CreatedAt).HasDefaultValueSql("GetDate()")
                .ValueGeneratedOnAdd();

            builder.HasMany(c => c.Books)
                .WithOne(b => b.Category)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
