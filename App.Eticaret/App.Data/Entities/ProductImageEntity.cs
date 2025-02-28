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
    public class ProductImageEntity : BaseEntity
    {        
        public int ProductId { get; set; }
        public string Url { get; set; } = default!;

        //nav prop
        public ProductEntity Product { get; set; } = default!;
    }
    internal class ProdcutImageEntityConfiguration : IEntityTypeConfiguration<ProductImageEntity>
    {
        public void Configure(EntityTypeBuilder<ProductImageEntity> builder)
        {
            builder.HasOne(p => p.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
