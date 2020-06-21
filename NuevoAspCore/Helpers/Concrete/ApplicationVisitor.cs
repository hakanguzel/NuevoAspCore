using System;
using System.Threading;
using System.Threading.Tasks;
using NuevoAspCore.Helpers.Abstract;

namespace NuevoAspCore.Helpers.Concrete
{
    public class ApplicationVisitor : IApplicationVisitor
    {
        private readonly IApplicationMonitorService _monitorService;
        private readonly IConfigurationService _configurationService;

        public ApplicationVisitor(IApplicationMonitorService monitorService,
            IConfigurationService configurationService)
        {
            _monitorService = monitorService;
            _configurationService = configurationService;
        }

        public async Task StartAsync()
        {
            await _monitorService.CheckApplicationsAsync();

            await CompleteAsync();
        }

        public async Task CompleteAsync()
        {
            var delay = await GetDelayAsync();
            Thread.Sleep(delay);

            await StartAsync();
        }

        private Task<TimeSpan> GetDelayAsync()
        {
            return _configurationService.GetDelayAsync();
        }
    }
}
