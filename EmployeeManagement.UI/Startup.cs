using AutoMapper;
using EmployeeManagement.BusinessEngine.Abstracts;
using EmployeeManagement.BusinessEngine.Concretes;
using EmployeeManagement.Common.Mappings;
using EmployeeManagement.Data.Abstracts;
using EmployeeManagement.Data.Concretes;
using EmployeeManagement.Data.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI
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
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDbContext<EmployeeManagementContext>(options=> options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddAutoMapper(typeof(Maps));
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();
            services.AddScoped<IEmployeeLeaveAllocationDal, EmployeeLeaveAllocationDal>();
            services.AddScoped<IEmployeeLeaveRequestDal, EfEmployeeLeaveRequestDal>();
            services.AddScoped<IEmployeeLeaveTypeDal, EfEmployeeLeaveTypeDal>();
            services.AddScoped<IEmployeeLeaveTypeService, EmployeeLeaveTypeManager>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name:"default", pattern:"{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
