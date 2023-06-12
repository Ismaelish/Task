using Microsoft.AspNetCore.Mvc;
using MaximaMachineriesInc.Models;
using MaximaMachineriesInc.DAL;
using Form_Request.Models;
using System.Diagnostics;
using MaximaMachineriesInc;


namespace MaximaMachineriesInc.Controllers
{


 public class RFSController : Controller
{
    private readonly RequestDbContext _dbcontext;

    public RFSController(RequestDbContext context)
    {
        _dbcontext = context;
       
    }
        [HttpGet]
 
    public IActionResult EntryForm()
        {
            return View();
        }
    [HttpGet]
    public IActionResult Index(string Disp)
    {
            GlobalVar.DispName = Disp;
            IEnumerable<RFS> objlist = _dbcontext.Reimbursement.Where(u => u.SystemUserID == GlobalVar.UserID);

            return View (objlist);

        }

        private IActionResult View(IEnumerable<RFS> objlist, string v)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult EntryForm(RFS Model)
        {
            if (ModelState.IsValid)
            {
     
                _dbcontext.Reimbursement.Add(Model);
                _dbcontext.SaveChanges();

            
                return Redirect("~/RFS/Index");

            }
            return View(Model);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //VIEW DETAILS
        public IActionResult TranDetails(int? TranCompNo)
        {
            var tranView = _dbcontext.Reimbursement.Find(TranCompNo);
            if (tranView == null)
            {
                return NotFound();
            }
            return View(tranView);
        }
    }
    public class HRController : Controller
    {
        private readonly HRDbContext _dbcontext;
        public HRController(HRDbContext context)
        {
            _dbcontext = context;
        }
        [HttpPost]
        public IActionResult EntryForm()
        {
            IEnumerable<Employee> objlist = _dbcontext.Tab201_1EmpInfo;
            return View(objlist);
        }

    }
    

}
