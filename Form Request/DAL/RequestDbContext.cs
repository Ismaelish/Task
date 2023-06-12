using MaximaMachineriesInc.Models;
using Microsoft.EntityFrameworkCore;

namespace MaximaMachineriesInc.DAL
{
    public class RequestDbContext : DbContext
    {
        public RequestDbContext(DbContextOptions<RequestDbContext> options) : base(options)
        {
        }
            public DbSet<RFS> Reimbursement { get; set; }
        
    
    }
}
