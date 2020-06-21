using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models.DbModels;
using NuevoAspCore.Models.Dtos;

namespace NuevoAspCore.Helpers.Concrete
{
    public class ApplicationMonitorService : IApplicationMonitorService
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly IApplicationChecker _checker;

        public ApplicationMonitorService()
        {
        }


        public ApplicationMonitorService(IUnitOfWorkFactory uowFactory,
            IApplicationChecker checker)
        {
            _uowFactory = uowFactory;
            _checker = checker;
        }

        public async Task CheckApplicationsAsync()
        {
            var uow = _uowFactory.Create();

            var applications = await uow.Get<WebSites>().AsQueryable().ToArrayAsync();

            var filter = applications.Where(x =>
                x.LastSuccessCheckDate is null ||
                x.LastSuccessCheckDate.Value.Add(TimeSpan.FromMilliseconds(x.SitesCheckDelay)) < DateTime.Now);

            foreach (var application in filter)
            {
                // Check application
                var checkResult = await CheckApplicationAsync(application);

                // Save result
                if (!checkResult.IsSuccess)
                    await SaveErrorResultAsync(application, checkResult);
                else
                    await SaveResultAsync(application);
            }
        }

        private Task<CheckResult> CheckApplicationAsync(WebSites application)
        {
            return _checker.CheckApplicationAsync(application);
        }

        private async Task SaveResultAsync(WebSites application)
        {
            var uow = _uowFactory.Create();

            application.LastSuccessCheckDate = DateTime.Now;
            application.ErrorStatus = 2;
            await uow.SaveChangesAsync();
        }


        private async Task SaveErrorResultAsync(WebSites application, CheckResult checkResult)
        {

            try
            {
                var uow = _uowFactory.Create();

                var historyRecord = new WebSiteError
                {
                    WebSitesId = application.WebSitesId,
                    ErrorTime = DateTime.Now,
                    ErrorStatus = (int) checkResult.State
                };
                application.LastSuccessCheckDate = DateTime.Now;
                application.ErrorStatus = (int) checkResult.State;

                var user = await uow.Get<Users>().Where(x => x.UserId == application.UserId).AsQueryable().FirstOrDefaultAsync();


                uow.Get<WebSiteError>().Add(historyRecord);
                await uow.SaveChangesAsync();
                var sendMail = new MailDto();
                sendMail.Subject = "Web Site Error";
                sendMail.ErrorName = checkResult.ErrorMessage;
                sendMail.SendMailAdress = user.Email;
                sendMail.WebSiteAdress = application.SiteUrl;

                var _eMailPermission = uow.Get<Configuration>().AsQueryable().Where(x => x.ConfigurationName == "SendEmailPermission").FirstOrDefault().ConfigurationValue;


                if (_eMailPermission == "1")
                    new SendMail().Mail(sendMail);
            }
            catch (Exception)
            {
            }

        }
    }
}
