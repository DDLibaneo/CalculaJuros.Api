using CalculaJuros.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Api.Integration.Tests.Environment
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        { }

        protected override void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpRequester, FakeHttpRequester>();
        }
    }
}