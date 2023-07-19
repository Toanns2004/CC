using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        [Table(name: "Products")]
        internal class Products
        {
            [Key]
            public string? Id { get; set; }
            public string? Name { get; set; }
            public float Price { get; set; }
        }
   
}
