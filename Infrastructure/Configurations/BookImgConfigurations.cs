using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Configurations
{
    public class BookImgConfigurations : IEntityTypeConfiguration<BookImg>
    {
        public void Configure(EntityTypeBuilder<BookImg> builder)
        {
            builder.HasKey(img => img.Id);
            builder.Property(img => img.ImageUrl).HasMaxLength(250);

        }
    }
}
