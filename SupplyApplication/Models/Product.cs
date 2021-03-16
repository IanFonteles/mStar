using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SupplyApplication.Models {
    public class Product {
        [Display(Name = "Número de Registro")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Manufacturer")]
        public int ManufacturerId { get; set; }
        [Display(Name = "Fabricante")]
        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }

        [Display(Name = "Tipo de Produto")]
        public virtual ProductType ProductType { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

    }
}
