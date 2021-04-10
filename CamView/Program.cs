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
        private static Mutex m_instance;  //������ ������ 1 ���. !!!
        private const string m_appName = "CamView";  //������ ������ 1 ���. !!!

        public static void Main(string[] args)
        {
            //Encoding cmd - NuGet: System.Text.Encoding.CodePages
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            bool tryCreateNewApp;  //������ ������ 1 ���. !!!
            m_instance = new Mutex(true, m_appName, //������ ������ 1 ���. !!!
                    out tryCreateNewApp); //������ ������ 1 ���. !!!
            if (tryCreateNewApp) //������ ������ 1 ���. !!!
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
