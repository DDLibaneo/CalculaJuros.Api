using Microsoft.Extensions.Configuration;

namespace CalculaJuros.Api.Integration.Tests.Environment
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration)
            : base(configuration)
        { }
    }
}