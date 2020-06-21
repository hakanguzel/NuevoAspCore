using System.Threading;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NuevoAspCore.Helpers.Abstract;
using NuevoAspCore.Helpers.Concrete;
using NuevoAspCore.Models;
using Microsoft.OpenApi.Models;
using IApplicationLifetime = Microsoft.Extensions.Hosting.IApplicationLifetime;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace NuevoAspCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment currentEnvironment)
        {
            CurrentEnvironment = currentEnvironment;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment CurrentEnvironment { get; }

        private static Thread _backgroundThread;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<NuevoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("NuevoConnection")),
                ServiceLifetime.Transient,
                ServiceLifetime.Transient);



            // Add application services.
            services.AddUnitOfWork();
            services.AddCustomHttpClient();
            services.AddApplicationChecker();
            services.AddApplicationMonitor();
            services.AddConfigurationService();
            services.AddApplicationVisitor();


            IAppSettings appSettings = new AppSettings();
            Configuration.GetSection("appSettings").Bind(appSettings);
            services.AddSingleton(appSettings);



            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
                options =>
            {
                options.LoginPath = "/Users/Login/";
            });

             services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("CoreSwagger", new OpenApiInfo { Version = "1.0", Description = "my api " });
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [System.Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApplicationLifetime applicationLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();



            //use authenticaiton
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=WebSites}/{action=Index}/{id?}");
            });



            applicationLifetime.ApplicationStarted.Register(() =>
            {
                var provider = app.ApplicationServices;
                var visitor = (IApplicationVisitor)provider.GetService(typeof(IApplicationVisitor));
                _backgroundThread = new Thread(() => visitor.StartAsync());
                _backgroundThread.Start();
            });

            applicationLifetime.ApplicationStopping.Register(() =>
            {
                if (_backgroundThread != null)
                {
                    if (_backgroundThread.IsAlive)
                    {
                        _backgroundThread.Abort();
                    }
                }
            });

            app.UseSwagger()
                .UseSwaggerUI(c =>
                {
                    //TODO: Either use the SwaggerGen generated Swagger contract (generated from C# classes)
                    c.SwaggerEndpoint("/swagger/CoreSwagger/swagger.json", "Swagger Test .Net Core");

                    //TODO: Or alternatively use the original Swagger contract that's included in the static files
                    // c.SwaggerEndpoint("/swagger-original.json", "Swagger Petstore Original");
                });


        }
    }
}
