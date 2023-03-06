using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEcommerce.Shared
{
    public class Products
    {
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;
        public String Description { get; set; } = String.Empty;
        public String ImageUrl { get; set; } = String.Empty;
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }



    }
}
