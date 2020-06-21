using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Models.DbModels;

namespace NuevoAspCore.Helpers.Concrete
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly int _defaultDelay;

        public ConfigurationService(IUnitOfWorkFactory uowFactory,
            IAppSettings appSettings)
        {
            _uowFactory = uowFactory;
            _defaultDelay = appSettings.DefaultDelay;
        }

        public async Task<TimeSpan> GetDelayAsync()
        {
            var uow = _uowFactory.Create();

            var config = await uow.Get<Configuration>().AsQueryable().Where(x => x.ConfigurationName == "Delay").OrderBy(x => x.ConfigurationValue).FirstOrDefaultAsync();
            if (config != null)
            {
                if(int.TryParse(config.ConfigurationValue, out var tryConfigurationValue))
                    return TimeSpan.FromMilliseconds(tryConfigurationValue);
            }

            return TimeSpan.FromSeconds(_defaultDelay);
        }
    }
}
