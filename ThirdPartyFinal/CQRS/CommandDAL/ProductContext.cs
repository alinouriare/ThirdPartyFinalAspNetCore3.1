using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandDAL
{
    public abstract class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

      
    }


    public class ProductCommandRepository : IProductCommandRepository
    {
        private readonly CommandProduct commandProduct;

        public ProductCommandRepository(CommandProduct commandProduct)
        {
            this.commandProduct = commandProduct;
        }
        public void Add(Product product)
        {
            commandProduct.Add(product);
            commandProduct.SaveChanges();
        }
    }

    public class ProductQueryRepository : IProductQueryRepository
    {
        private readonly QueryProduct queryProduct;

        public ProductQueryRepository(QueryProduct queryProduct)
        {
            this.queryProduct = queryProduct;
        }
        public List<Product> GetAll()
        {
           return queryProduct.Products.ToList();
        }
    }

}
