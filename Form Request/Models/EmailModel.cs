using System.Security.AccessControl;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;
namespace SendingMail.Models
{
    public class EmailModel
    {
        public string To { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public IFormFile Attachment { get; set; } = null!;

        
		public string CC { get; set; } = null!;
    }
}