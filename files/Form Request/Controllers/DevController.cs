using Microsoft.AspNetCore.Mvc;

namespace MaximaMachineriesInc.Controllers
{
    public class DevController : Controller
{
    public IActionResult Index(string Disp)
    {
            GlobalVar.DispName = Disp;
        return View();
    }
}
}
