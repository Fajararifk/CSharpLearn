using Microsoft.EntityFrameworkCore;

namespace EFCore_NorthwindDB
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationContext()
        {
        }

    }
}