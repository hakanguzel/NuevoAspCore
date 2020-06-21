using System.Linq;
using System.Net;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models.DbModels;
using NuevoAspCore.Models.Dtos;

namespace NuevoAspCore.Helpers.Concrete
{
    public class SendMail
    {
        private readonly IUnitOfWorkFactory _uowFactory;

        public SendMail()
        {
        }


        public void Mail(MailDto sendMail)
        {
            var uow = _uowFactory.Create();
            var _eMailAdress = uow.Get<Configuration>().AsQueryable().Where(x => x.ConfigurationName == "EMailAdress")
                .FirstOrDefault().ConfigurationValue;
            var _eMailPassword = uow.Get<Configuration>().AsQueryable()
                .Where(x => x.ConfigurationName == "EMailPassword").FirstOrDefault().ConfigurationValue;
            var _eMailSmtp = uow.Get<Configuration>().AsQueryable().Where(x => x.ConfigurationName == "EMailSmtp")
                .FirstOrDefault().ConfigurationValue;



            SmtpClient client = new SmtpClient();
            MailAddress from = new MailAddress(_eMailAdress);
            MailAddress to = new MailAddress(sendMail.SendMailAdress);
            MailMessage msg = new MailMessage(from, to);
            msg.IsBodyHtml = true;
            msg.Subject = sendMail.Subject;
            msg.Body += @"
            <div class='text' style='padding: 0 2.5em; text-align: center;'>
                <h2>Please Check Your Website Address.</h2>
                <h4>" + sendMail.WebSiteAdress + @"</h4>
                <h3>You get the error below.</h3>
                <li>" + sendMail.ErrorName + @"</li>
                <p><a href='" + sendMail.WebSiteAdress + @"' class='btn btn-primary'>Visit Your Website</a></p>
            </div>";


            msg.CC.Add(sendMail.SendMailAdress);
            NetworkCredential info = new NetworkCredential(_eMailAdress, _eMailPassword);
            client.Port = 587;
            client.Host = _eMailSmtp;
            client.EnableSsl = true;
            client.Credentials = info;
            client.Send(msg);
        }
    }
}
