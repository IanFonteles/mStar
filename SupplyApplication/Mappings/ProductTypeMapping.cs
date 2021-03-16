using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Mappings {
    public class ProductTypeMapping : IEntityTypeConfiguration<ProductType> {
        public void Configure(EntityTypeBuilder<ProductType> builder) {
            builder.ToTable(nameof(ProductType)).HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(180);


        }
    }
}
