using MaximaMachineriesInc.Models;
using SideMenuBar.Models;
using Microsoft.EntityFrameworkCore;




namespace MaximaMachineriesInc.DAL
{
    public class ApplicationDbContext : DbContext
{       
        public DbSet<Q_SysRoute> Q_SysRoute { get; set; }
            public DbSet<User> Sys_Client_SP_Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        

        //public DbSet<Shared> SysMenu { get; set; }

        public DbSet<Shared> Q_UserMenu { get; set; }

        

       




    }
}
