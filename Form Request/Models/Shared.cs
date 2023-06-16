using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace SideMenuBar.Models
{
   
    public class Shared
    {

        [Key]
        public int ID { get; set; }

        public string? Menu { get; set; }

        public string? SubMenu { get; set; }
        
        public string? Category { get; set; }

        public string? Controller { get; set; }

        public string? Action { get; set; }

        public int? SystemuserID { get; set; }

        public string? DispName { get; set; }

        public string? TblName { get; set; }

    }
    public class Q_SysRoute
    {

        [Key]
        public int ID { get; set; }
        public string? Section { get; set; }
        public string? Dept { get; set; }
        public string? Branch { get; set; }
        public string? App { get; set; }
        public int? RouteSteps { get; set; }
        public int? ApproverID { get; set; }

    }


}
