using Microsoft.EntityFrameworkCore;

namespace CommandDAL
{
    public class QueryProduct : ProductContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QueryProduct;Integrated Security=true;");
        }
    }
}
