using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyApplication.Models {
    public class ProductType {

        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }



    }
}
