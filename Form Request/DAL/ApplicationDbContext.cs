using MaximaMachineriesInc.Models;
using SideMenuBar.Models;
using Microsoft.EntityFrameworkCore;




namespace MaximaMachineriesInc.DAL
{
    public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Sys_Client_SP_Users { get; set; }

        //public DbSet<Shared> SysMenu { get; set; }

        public DbSet<Shared> Q_UserMenu { get; set; }

      


    }
}
