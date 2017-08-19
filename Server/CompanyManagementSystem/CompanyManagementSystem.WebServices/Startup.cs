namespace CompanyManagementSystem.WebServices
{
    using Data;
    using Data.Abstraction;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using ModelMapping;
    using ModelMapping.Abstraction;
    using Services;
    using Services.Abstraction;

    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            this.Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IEmployeeMapper, EmployeeMapper>();
            services.AddTransient<IPermissionMapper, PermissionMapper>();
            services.AddTransient<IPositionMapper, PositionMapper>();

            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IPermissionService, PermissionService>();
            services.AddTransient<IPositionService, PositionService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(this.Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "api/{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
