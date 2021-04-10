using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CamView
{
    public class Program
    {
        private static Mutex m_instance;  //Запуск только 1 экз. !!!
        private const string m_appName = "CamView";  //Запуск только 1 экз. !!!

        public static void Main(string[] args)
        {
            //Encoding cmd - NuGet: System.Text.Encoding.CodePages
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            bool tryCreateNewApp;  //Запуск только 1 экз. !!!
            m_instance = new Mutex(true, m_appName, //Запуск только 1 экз. !!!
                    out tryCreateNewApp); //Запуск только 1 экз. !!!
            if (tryCreateNewApp) //Запуск только 1 экз. !!!
            {
                CreateHostBuilder(args).Build().Run();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel();
                    webBuilder.UseUrls("http://*:8525"); //.UseStaticWebAssets();
                    webBuilder.UseStartup<Startup>();
                }); //.UseWindowsService();

    }
}
