using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // add dịch vụ mvc vào đây và cũng tương tự với razor hoặc blaze
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                // định nghĩa cách phân thích (rounting) cho các pattern url
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}"
                    // nếu 0 có thông tin action như line 42 thì mặc định gọi vào index như này pattern: "{controller}/{action=Index}" 
                    // nếu 0 có controller thì tự động gọi vào controller Home như này pattern: "{controller=Home}/{action}" (xóa từ dòng 34-37)
                    );

            });
        }
    }
}
