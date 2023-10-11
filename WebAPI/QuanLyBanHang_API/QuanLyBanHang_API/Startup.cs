using System.Runtime.InteropServices;
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
using QuanLyBanHang_API.Models;
using QuanLyBanHang_API.Data;
using Microsoft.EntityFrameworkCore;

namespace QuanLyBanHang_API
{
    public class Startup
    {
        public ServerVersion mySplConnectionStr;
        private AutoDetect mySqlConnentionStr;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // this method gets called by the runtime. use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services) 
        {
            string mySplConcentionStr = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<ApplicationDbContext>(option => option.UseMySql(mySplConnectionStr, ServerVersion.AutoDetect(mySqlConnentionStr)));
            
            services.AddControllers();
        }

        // this method gets called by the runtime. use this method to configure the HTTP request pipeline.
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

