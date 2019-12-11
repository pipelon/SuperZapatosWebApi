using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SuperZapatosWebApi.Contexts;

namespace SuperZapatosWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webhost = CreateHostBuilder(args).Build();

            //Ejecutar las migraciones desde IIS
            using (var scope = webhost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var applicationDbContext = services.GetService<ApplicationDbContext>();
                applicationDbContext.Database.Migrate();
            }

            webhost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
