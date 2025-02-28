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
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Color { get; set; } = default!;
        public string IconCssClass { get; set; } = default!;
        //nav prop
        public List<ProductEntity> Products { get; set; } = default!;
    }
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Color).IsRequired().HasMaxLength(50);
            builder.Property(x => x.IconCssClass).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();

        }
    }
} 
