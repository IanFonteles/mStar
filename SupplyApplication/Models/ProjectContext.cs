using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplyApplication.Models;
using SupplyApplication.Mappings;

namespace SupplyApplication.Models {
    public class ProjectContext : DbContext {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ManufacturerMapping());
            modelBuilder.ApplyConfiguration(new ProductTypeMapping());
            modelBuilder.ApplyConfiguration(new InventoryMapping());

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<ProductEntry> ProductEntry { get; set; }
        public DbSet<ProductOut> ProductOut { get; set; }





    }
}
