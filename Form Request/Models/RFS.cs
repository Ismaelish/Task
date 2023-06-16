using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MaximaMachineriesInc.DAL;
using Microsoft.VisualBasic;
using Microsoft.Identity.Client;

namespace MaximaMachineriesInc.Models
{
    public class RFS
{

        [Key]
        public int TranCompNo { get; set; }

        public int? SystemUserID { get; set; }

        [DisplayName("Reference")]
        public string? Reference { get; set; }
        [DisplayName("ReferenceDate")]
        public DateTime? ReferenceDate { get; set; }
        public string? Section { get; set; }
        public string? Dept { get; set; }

        public string? Branch { get; set; }




    }
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public int EmoNo { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? MName { get; set; }
        public string? NameExt { get; set; }
        public string? Dept { get; set; }
        public string? Section { get; set; }
        public string? LvlCode { get; set; }
    }
   
    public class ModelMix
    {
        public IEnumerable<Employee> Employee { get; set;}
        [Key]
        public int ID { get; set; }
        public int EmoNo { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? MName { get; set; }
        public string? NameExt { get; set; }
        public string? Dept { get; set; }
        public string? Section { get; set; }
        public string? LvlCode { get; set; }

        public IEnumerable<RFS> RFS { get; set;}
        [Key]
        public int TranCompNo { get; set; }

        public int? SystemUserID { get; set; }

        [DisplayName("Reference")]
        public string? Reference { get; set; }
        [DisplayName("ReferenceDate")]
        public DateTime? ReferenceDate { get; set; }

        public DateTime? PostDate { get; set; } = DateTime.Now;

    }

}
