using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionConcoursCore.Data;
using GestionConcoursCore.Models;
using GestionConcoursCore.Services;
using GestionConcoursCore.Services_User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestionConcoursCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc();
            services.AddDbContext<GestionConcourCoreDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
            services.AddTransient<ISearch3Service, Search3ServiceImp>();
            services.AddTransient<ICorbeil3Service, Corbeil3ServiceImp>();
            services.AddTransient<ISelectionService, SelectionServiceImp>();
            services.AddTransient<IPreselectionService, PreselectionServiceImp>();
            services.AddTransient<ICandidatService, CandidatServiceImp>();
            services.AddTransient<Services.IEpreuveService, Services.EpreuveServiceImp>();
            services.AddTransient<Services_User.IEpreuveService, Services_User.EpreuveServiceImp>();
            services.AddScoped<IEnregistrementService, EnregistrementServiceImp>();
			services.AddScoped <ICorrectionService, CorrectionServiceImp> ();
            services.AddTransient<IStatistiqueService, StatistiqueServiceImpl>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Landing}/{action=Index}/{id?}");
            });
        }
    }
}
