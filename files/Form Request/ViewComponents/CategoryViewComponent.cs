using MaximaMachineriesInc;
using MaximaMachineriesInc.DAL;
using MaximaMachineriesInc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SideMenuBar.Models;
using System.Drawing;

namespace WebApplication1.ViewComponents
{
    [ViewComponent(Name = "Category")]
    public class CategoryViewComponent : ViewComponent
{
        private readonly ApplicationDbContext _dbcontext;
        public CategoryViewComponent (ApplicationDbContext Context)
        {
            _dbcontext = Context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var access = _dbcontext.Q_UserMenu.Where(i => i.SystemuserID == GlobalVar.UserID);
            return View("Index1", access.ToList());
        }
    }
}
