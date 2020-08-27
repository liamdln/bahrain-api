using bahrain_api.Models;
using Microsoft.EntityFrameworkCore;

namespace bahrain_api.Data
{

    public class ATControllerContext : DbContext
    {

        public ATControllerContext(DbContextOptions<ATControllerContext> opt) : base(opt)
        {
            
        }

        public DbSet<ATController> ATControllers { get; set; } 

    }

}