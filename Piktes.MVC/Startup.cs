using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Piktes.MVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var mvcBuilder = services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);


            var directory = Directory.GetDirectories(Path.Combine(AppContext.BaseDirectory, "plugins"));
            var dir2 = AppDomain.CurrentDomain.GetAssemblies().Where(at => at.FullName.StartsWith("Plugin_"));
            foreach (var dir in directory)
            {
                var pluginFile = Path.Combine(dir, Path.GetFileName(dir) + ".dll");
                // The AddPluginFromAssemblyFile method comes from McMaster.NETCore.Plugins.Mvc
                mvcBuilder.AddPluginFromAssemblyFile(pluginFile);
            }
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app
                .UseRouting()
                .UseEndpoints(r =>
                {
                    r.MapDefaultControllerRoute();
                });
        }
    }
}
