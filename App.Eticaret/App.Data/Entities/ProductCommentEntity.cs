using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    public class ProductCommentEntity : BaseEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; } = default!;
        public byte StarCount { get; set; }
        public bool IsConfirmed { get; set; } = false;
        //nav prop
        public ProductEntity Product { get; set; } = default!;
        public UserEntity User { get; set; } = default!;
    }
    internal class ProductCommentEntityConfiguration : IEntityTypeConfiguration<ProductCommentEntity>
    {
        public void Configure(EntityTypeBuilder<ProductCommentEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Comment).IsRequired().HasMaxLength(500);
            builder.Property(x => x.StarCount).IsRequired();
            builder.Property(x => x.IsConfirmed).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany(e=>e.Comments)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
