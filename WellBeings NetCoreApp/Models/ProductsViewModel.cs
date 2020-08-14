using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WellBeings_NetCoreApp.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public virtual ProductType productType { get; set; }


    }
}