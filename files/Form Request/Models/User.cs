using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace MaximaMachineriesInc.Models
{
    public class User
{
        [Key]
        public int SystemUserID { get; set; }

        public string SystemUserName { get; set; } 
        public string PassCode { get; set; }

	
	}
 
}
