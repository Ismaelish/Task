using MaximaMachineriesInc.Models;
using Microsoft.EntityFrameworkCore;

namespace MaximaMachineriesInc.DAL
{
    public class HRDbContext : DbContext
{
        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Tab201_1EmpInfo { get; set; }


    
}
}
