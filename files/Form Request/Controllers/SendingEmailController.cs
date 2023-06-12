using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using SendingMail.Models;
using Form_Request.Models;
using Microsoft.Extensions.Configuration;

public class SendingEmail : Controller
{
    private IConfiguration Configuration;
    public SendingEmail(IConfiguration _configuration)
    {
        Configuration = _configuration;
    }

    // GET: Home
    public IActionResult Email()
    {
        return View("../Home/Email");
    }

    [HttpPost]
    public IActionResult Email(EmailModel model)
    {
        //Read SMTP settings from AppSettings.json.
        string host = this.Configuration.GetValue<string>("Smtp:Server");
        int port = this.Configuration.GetValue<int>("Smtp:Port");
        string fromAddress = this.Configuration.GetValue<string>("Smtp:FromAddress");
        string userName = this.Configuration.GetValue<string>("Smtp:UserName");
        string password = this.Configuration.GetValue<string>("Smtp:Password");

        using (MailMessage mm = new MailMessage(fromAddress, model.To)) 
        {   
            mm.Subject = model.Subject;
            mm.CC.Add(model.CC);
            mm.Body = model.Body;

            mm.IsBodyHtml = true;
          
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = host;
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(userName, password);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.Port = port;
                smtp.Send(mm);
                {
                    Console.Write("Email has been sent!");
                }
            }
            return Redirect("~/home/home");

        }
      
    }
}