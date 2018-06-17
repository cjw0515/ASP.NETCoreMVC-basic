using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreMVC_basic.Data;
using ASP.NETCoreMVCbasic.Data;
using ASP.NETCoreMVCbasic.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NETCoreMVC_basic
{
    public class Startup
    {

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MVCbasicContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("MVCbasicConnection"));
            });

            //닷넷코어에서 제공하는 서비스 생명주기들
            services.AddTransient<DbSeeder>();   //필요할 때 마다 생성되고 캐시에 머물러있지 않음. 새로운 http요청이 있을 때마다 새로운 인스턴스를 매번 생성한다.
            services.AddScoped<ITeacherRepository, TeacherRepository>(); // http 요청이 있을 때 마다 인스턴스를 생성, 그 요청 내에서 계속 재사용함.
            
            services.AddMvc(); // 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DbSeeder seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            seeder.SeedDatabase().Wait();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
