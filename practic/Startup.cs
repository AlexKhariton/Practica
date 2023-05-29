using Microsoft.EntityFrameworkCore;
using practic.Data;
using practic.Data.Interfaces;
using practic.Data.Repository;

namespace practic
{
    public class Startup
    {
        private IConfigurationRoot _confsting;

        [Obsolete]
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddTransient<Service>();
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllRealtors, RealtorRepository>(); 
            services.AddTransient<IRealtorsCategory, CategoryRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }
        public async void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Realtors/{action}/{category?}", defaults: new {Controller="Realtors", action="List"});
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
