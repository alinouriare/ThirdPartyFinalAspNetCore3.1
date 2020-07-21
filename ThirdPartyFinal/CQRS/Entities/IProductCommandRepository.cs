using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public interface IProductCommandRepository
    {
        void Add(Product product);
    }
}
