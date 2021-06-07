using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); // permette di visualizzare immagini statiche
            /* app.Run(async (context) =>
             {
                 await context.Response.WriteAsync("Hello World!");
             });*/ //commentata parte iniziale


            app.UseMvcWithDefaultRoute(); // commentata per prova ma va usata
          /*  app.UseMvc(routeBuilder => // route creata manualmante ma andrebbe usata quella scritat nella riga sopra
            {
                routeBuilder.MapRoute("default", "{Controller}/{action}/{id}");
            });*/
        }
    }
}
