using System.ComponentModel.DataAnnotations;

namespace EmployeeInfo.Models
{
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
}
