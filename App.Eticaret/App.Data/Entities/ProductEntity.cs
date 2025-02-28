using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    public class ProductEntity : BaseEntity
    {
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int StockAmount { get; set; }
        public bool Enabled { get; set; } = true;

        //nav prop
        public UserEntity Seller { get; set; } = default!;
        public CategoryEntity Category { get; set; } = default!;
        public ICollection<ProductImageEntity> Images { get; set; } = null!;
        public ICollection<ProductCommentEntity> Comments { get; set; } = null!;
    }
    internal class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SellerId).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.StockAmount).IsRequired();
            builder.Property(x => x.Enabled).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();

            builder.HasOne(x => x.Seller)
                .WithMany()
                .HasForeignKey(x => x.SellerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
