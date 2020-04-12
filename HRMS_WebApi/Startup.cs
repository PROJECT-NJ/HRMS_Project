using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using HRMS_WebApi.Data;

namespace HRMS_WebApi
{
    public class Startup
    {
        //Add Configuration
        private string _ConnectionString = null;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(option =>
                    option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            this.SetConnectionString();
            services.AddDbContext<HrmsContext>(option => 
                option.UseSqlServer(_ConnectionString)
            );
        }

        public void SetConnectionString()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = Configuration["DbServer"];
            builder.InitialCatalog = Configuration["DbName"];
            builder.UserID = Configuration["DbUser"];
            builder.Password = Configuration["DbPassword"];
            _ConnectionString = builder.ConnectionString;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
