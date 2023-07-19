using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductDBcontext : DbContext
    {
        public ProductDBcontext(DbContextOptions<ProductDBcontext> options)
                 : base(options) { }
        public DbSet<Products> Product { get; set; }
    }
}