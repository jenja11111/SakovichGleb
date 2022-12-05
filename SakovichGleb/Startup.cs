using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Repository;
using SakovichGleb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SakovichGleb
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IWebHostEnvironment env)
        {
            _confString = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            // связь интерфейса и репозитория
            services.AddTransient<IUser, UserRepository>();
            services.AddTransient<ISemestr, SemestrRepository>();
            services.AddTransient<IMonth, MonthRepository>();
            services.AddTransient<INHours, NHoursRepository>();
            services.AddTransient<IRaspisanie, RaspisanieRepository>();

            services.AddAuthentication("Cookie")
                .AddCookie("Cookie", config =>
                {
                    config.LoginPath = "/User/Login";
                });
            services.AddAuthorization();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
