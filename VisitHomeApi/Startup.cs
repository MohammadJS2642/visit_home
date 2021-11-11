using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using VisitHomeApi.Data;

namespace VisitHomeApi
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VisitHomeApi", Version = "v1" });
            });

            // services.AddTransient<MySqlConnection>(_ =>
            //  new MySqlConnection(Configuration["VisitHome"]));

            //services.AddDbContext<visithomeContext>(
            //    options => options.UseMySQL("VisitHome")
            //);

            //services.AddDbContext<VisitHomeContext>(options =>
            //options.UseSqlServer("VisitHome"));

            //services.AddDbContext<visithomeContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("visithomeContext")));

            services.AddDbContext<VisitHomeContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("VisitHome"))
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VisitHomeApi v1"));
            }

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
