using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.TestHost;

namespace CalculaJuros.Api.Integration.Tests.Environment
{
    public class LocalEnvironment : IEnvironment
    {
        public HttpClient Client { get; }

        private readonly TestServer _server;

        public LocalEnvironment()
        {
            var builder = new WebHostBuilder()
                .UseStartup<TestStartup>();

            _server = new TestServer(builder);
            Client = _server.CreateClient();
        }
    }
}
