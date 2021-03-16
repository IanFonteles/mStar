using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Mappings {
    public class ProductEntryMapping : IEntityTypeConfiguration<ProductEntry> {
        public void Configure(EntityTypeBuilder<ProductEntry> builder) {
            builder.ToTable(nameof(ProductEntry)).HasKey(p => p.Id);
            builder.Property(p => p.InventoryQuantity);
            builder.Property(p => p.Date);

        }
    }
}
