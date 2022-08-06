using ApiGateway.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new WebHostBuilder();
            builder.UseKestrel();
            builder.UseContentRoot(Directory.GetCurrentDirectory());
            builder.ConfigureAppConfiguration((context, config) =>
            {
                config.SetBasePath(context.HostingEnvironment.ContentRootPath);
                config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                config.AddEnvironmentVariables();
            });
            builder.ConfigureServices((services) =>
            {
                services.AddOcelot();
            });
            builder.ConfigureLogging((logging) =>
            {
                logging.AddConsole();
            });
            builder.Configure(app =>
            {
                app.UseOcelot().Wait();
                app.UseMiddleware<LoggingMiddleware>();
            });
            builder.Build().Run();
        }
    }
}
