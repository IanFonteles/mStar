using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Models {
    public class ProductEntry {
        public int Id { get; set; }
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        [Display(Name = "Quantidade")]
        public int InventoryQuantity { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [Display(Name = "Produto")]
        public virtual Product Product { get; set; }
    }
}

