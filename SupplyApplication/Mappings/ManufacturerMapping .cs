using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Mappings {
    public class ManufacturerMapping : IEntityTypeConfiguration<Manufacturer> {
        public void Configure(EntityTypeBuilder<Manufacturer> builder) {
            builder.ToTable(nameof(Manufacturer)).HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(180);            


        }
    }
}
