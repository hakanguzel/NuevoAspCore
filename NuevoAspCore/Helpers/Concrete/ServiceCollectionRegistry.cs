using Microsoft.Extensions.DependencyInjection;
using NuevoAspCore.Helpers.Abstract;

namespace NuevoAspCore.Helpers.Concrete
{
    public static class ServiceCollectionRegistry
    {

        public static void AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, DbUnitOfWork>();
            services.AddSingleton<IUnitOfWorkFactory, DbUnitOfWorkFactory>();
        }

        public static void AddCustomHttpClient(this IServiceCollection services)
        {
            services.AddTransient<IHttpClient, HttpClient>();
        }

        public static void AddApplicationChecker(this IServiceCollection services)
        {
            services.AddTransient<IApplicationChecker, ApplicationChecker>();
        }

        public static void AddApplicationMonitor(this IServiceCollection services)
        {
            services.AddTransient<IApplicationMonitorService, ApplicationMonitorService>();
        }

        public static void AddConfigurationService(this IServiceCollection services)
        {
            services.AddTransient<IConfigurationService, ConfigurationService>();
        }

        public static void AddApplicationVisitor(this IServiceCollection services)
        {
            services.AddSingleton<IApplicationVisitor, ApplicationVisitor>();
        }
    }
}
