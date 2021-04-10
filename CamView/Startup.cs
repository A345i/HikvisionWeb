using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CamView.HelpClasses;
using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;
using CamView.UsersGroups;


namespace CamView
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            

            ////Чтобы кирилические символы не переводились в соответствующий Unicode Hex Character Code
            //services.Configure<WebEncoderOptions>(options =>
            //{
            //    options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            //});

            

            //JSRuntime
            services.AddScoped<IBrowserService, BrowserService>();

           

            //UserSettings
            services.AddSingleton<IUserSettings, UserSettings>();

            //GlobalUserID
            services.AddScoped<UserData>();

           

            //ICamHelper
            services.AddSingleton<ICamHelper, CamHelper>();

            services.AddResponseCompression(o =>
            {
                o.EnableForHttps = true;
            });

            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal;
            });

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller}/{action}");

                //endpoints.MapControllers(); //добавим поддержку контроллеров
                endpoints.MapBlazorHub();
                //endpoints.MapBlazorHub(option =>
                //{
                //    option.ApplicationMaxBufferSize = 1024000000; // larger size //MaxFileSize = 1000 * 1024 * 1024; = 1048576000
                //    option.TransportMaxBufferSize = 1024000000; // larger size
                //});

                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
