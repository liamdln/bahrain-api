using bahrain_api.Models;
using Microsoft.EntityFrameworkCore;

namespace bahrain_api.Data
{

    public class BahrainDataContext : DbContext
    {
        public BahrainDataContext(DbContextOptions<BahrainDataContext> opt) : base(opt)
        {
        }

        public DbSet<ATController> ATControllers { get; set; }
        public DbSet<StaffMember> StaffMembers { get; set; }
    }

}