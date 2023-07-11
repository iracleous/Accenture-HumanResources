using Accenture_HumanResources.Models;
using Microsoft.EntityFrameworkCore;

namespace Accenture_HumanResources.MyDbContext
{
    public class HrDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }


        public HrDbContext()
        {

        }

        public HrDbContext(DbContextOptions<HrDbContext> options)
       : base(options)
        {
        }
    }
}
