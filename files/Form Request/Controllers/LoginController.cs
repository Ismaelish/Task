using MaximaMachineriesInc.DAL;
using Microsoft.AspNetCore.Mvc;
using MaximaMachineriesInc.Models;

namespace MaximaMachineriesInc.Controllers
{
    public class LoginController : Controller
{
        private readonly ApplicationDbContext _dbcontext;

        public LoginController(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Forgotpassword()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Login(User model)

		{
            if (ModelState.IsValid)
            {
                var user = _dbcontext.Sys_Client_SP_Users.FirstOrDefault(u => u.SystemUserName == model.SystemUserName);
                if (user != null && model.PassCode == user.PassCode) {
                    GlobalVar.UserName = user.SystemUserName;
                    GlobalVar.UserID = user.SystemUserID;
                    return Redirect("~/Home/Home");
                }
                else
				{
					ViewBag.ErrorMessage = "Invalid Username or Password!!!";
					return View(model);
				}
			}
         
			return View(model);
		}
	}

}
