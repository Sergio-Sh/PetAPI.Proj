using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebAPI.Proj.BLL;
using WebAPI.Proj.DAL.Context;
using Microsoft.EntityFrameworkCore;
using WebAPI.Proj.DAL.Repositories;
using AutoMapper;
using BLL.MappingProfiles;
using System.Reflection;

namespace Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<ProjectProfile>();
                cfg.AddProfile<TaskProfile>();
                cfg.AddProfile<TeamProfile>();
                cfg.AddProfile<UserProfile>();
            },
            Assembly.GetExecutingAssembly());

            services.AddControllers();
            services.AddTransient<LINQ_Serviсe>();
            services.AddTransient<ProjectRepository>();
            services.AddTransient<TaskRepository>();
            services.AddTransient<TeamRepository>();
            services.AddTransient<UserRepository>();       

            services.AddDbContext<WebDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("WebDatabase")));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Token-Expired")
                .AllowCredentials()
                .WithOrigins("http://localhost:4200"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
