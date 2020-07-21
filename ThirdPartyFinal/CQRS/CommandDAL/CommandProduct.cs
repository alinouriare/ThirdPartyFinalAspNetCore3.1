using Microsoft.EntityFrameworkCore;

namespace CommandDAL
{
    public class CommandProduct : ProductContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CommandProduct;Integrated Security=true;");
        }
    }
}
