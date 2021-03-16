using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Mappings {
    public class InventoryMapping : IEntityTypeConfiguration<Inventory> {
        public void Configure(EntityTypeBuilder<Inventory> builder) {
            builder.ToTable(nameof(Inventory)).HasKey(p => p.Id);
            builder.Property(p => p.InventoryQuantity);
            builder.Property(p => p.Date);

        }
    }
}
