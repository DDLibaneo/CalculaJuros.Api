using CalculaJuros.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJuros.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            ConfigureApplicationServices(services);
            ConfigureHttpRequester(services);
            ConfigureHttpRequesterOptions(services);
        }

        protected virtual void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<ICalculaJurosService, CalculaJurosService>();
        }

        protected virtual void ConfigureHttpRequester(IServiceCollection services)
        {
            services.AddHttpClient<IHttpRequester, HttpRequester>();
        }

        private void ConfigureHttpRequesterOptions(IServiceCollection services)
        {
            services.AddSingleton<IHttpRequesterOptions, HttpRequesterOptions>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
