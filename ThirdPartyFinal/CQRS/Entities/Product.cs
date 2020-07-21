using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category  Category { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
