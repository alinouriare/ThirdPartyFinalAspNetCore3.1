using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IProductQueryRepository
    {

        List<Product> GetAll(); 
    }
}
