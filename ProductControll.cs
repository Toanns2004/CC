using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductControll
    {
   
            ProductDBcontext dbcontext;
            public ProductControll()
            {
                var studentDbOptions = new DbContextOptionsBuilder<ProductDBcontext>()
                    .UseSqlServer("Data Source=DESKTOP-GEHR83P\\SQLEXPRESS;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=12345678;Encrypt=False")
                    .Options;
                this.dbcontext = new ProductDBcontext(studentDbOptions);
            }
            public void GetAll()
            {
                var Product = dbcontext.Product.ToList();
                foreach (var item in Product)
                {
                    Console.WriteLine($" {item.Id} {item.Name} {item.Price}");
                }
            }
            public void AddProduct()
            {
                Console.Write("Id : ");
                string? i = Console.ReadLine();
                Console.Write("Name : ");
                string? n = Console.ReadLine();
                Console.Write("price : ");
                decimal p = Convert.ToDecimal(Console.ReadLine());


                var product = new Products
                {
                    Id = i,
                    Name = n,
                    Price = (float)p
                };

                try
                {
                    dbcontext.Product.Add(product);
                    dbcontext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public void DeleteProduct()
            {
                Console.Write("Delete Product by ID :");
                string id = Console.ReadLine();
                var deleteProducts = dbcontext.Product.Where(p => p.Id == id).First();
                if (deleteProducts != null)
                {
                    dbcontext.Product.Remove(deleteProducts);
                    dbcontext.SaveChanges();

                }
            }
        }
    
}
