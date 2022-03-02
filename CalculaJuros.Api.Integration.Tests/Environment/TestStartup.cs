using CalculaJuros.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CalculaJuros.Api.Integration.Tests.Environment
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        { }

        protected override void ConfigureApplicationServices(IServiceCollection services)
        {
            var controllersAssemblyType = typeof(Startup).GetTypeInfo().Assembly;
            services.AddMvc().AddApplicationPart(controllersAssemblyType);

            services.AddScoped<ICalculaJurosService, CalculaJurosService>();            
        }

        protected override void ConfigureHttpRequester(IServiceCollection services)
        {
            services.AddSingleton<IHttpRequester, FakeHttpRequester>();
        }
    }
}