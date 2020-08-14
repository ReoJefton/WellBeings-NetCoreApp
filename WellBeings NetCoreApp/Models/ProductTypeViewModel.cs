using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WellBeings_NetCoreApp.Models
{
    public class ProductType
    {
        public ProductType()
        {
            products = new List<Products>();
        }

        [Key]
        public int ProductTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> products { get; set; }


    }
}