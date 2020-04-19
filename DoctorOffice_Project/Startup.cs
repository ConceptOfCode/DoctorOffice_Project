using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DoctorOffice.DataLayer;
using DoctorOffice.Domains;
using DoctorOffice.Services;

namespace DoctorOffice_Project
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
            services.AddTransient<IClinicOpeningHoursRepository, clinicOpeningHoursRepository>();
            services.AddTransient<IClinicSpecificationsRepository, clinicSpecificationsRepository>();
            services.AddTransient<IClinicOpeningHoursRepository, clinicOpeningHoursRepository>();
            services.AddTransient<IServicesRepository, servicesRepository>();
            services.AddTransient<IPatientsRepository, patientsRepository>();
            services.AddTransient<ITurnsRepository, turnsRepository>();
            services.AddTransient<ApplicationDbContext, ApplicationDbContext>();
            services.AddTransient<IAuthorizationRepository, authorizationRepository>();
            services.AddTransient<IEmployeesRepository, employeesRepository>();
            services.AddTransient<INoteRepository, notesRepository>();
            services.AddTransient<IDoctorsPrescriptionsRepository, doctorsPrescriptionsRepository>();
            services.AddTransient<IMedicinesRpository, medicinesRepository>();
            services.AddTransient<IHowUsesRepository, howUsesRepository>();
            services.AddTransient<IMemoriesRepository, memoriesRepository>();
            services.AddTransient<ITemporaryPatientsRepository, temporaryPatientsRepository>();


            services.AddDbContext<ProjectContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DoctorOfficeConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DoctorOfficeConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                name: "areas",
                areaName: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
