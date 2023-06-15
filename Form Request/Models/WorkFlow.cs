using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MaximaMachineriesInc.Models
{
    public class WorkFlow
    {

    [Key]
    public int ID { get; set; }
    public DateTime? ReferenceDate { get; set; }
    public int? ToSysUserID { get; set; }
    public int? FromSysUserID { get; set; }
    public string? Msg { get; set; }
    public string? AssocAppName { get; set; }
    public int? SysAppID { get; set; }
    public int? SysAppTranCompNo { get; set; }
    public int? PolicySteps { get; set; }
    public string TempRef { get; set; }

    }
}
