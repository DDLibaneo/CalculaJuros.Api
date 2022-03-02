using CalculaJuros.Api.Integration.Tests.Environment;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Integration.Tests
{
    public class CalculaJurosApiFixture
    {
        private readonly IEnvironment _environment;

        public HttpClient Client => _environment.Client;

        public CalculaJurosApiFixture()
        {
            _environment = new LocalEnvironment();
        }

        public async Task<(T ResponseObject, HttpStatusCode StatusCode)> GetInApiAsync<T>(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await Client.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            var dto = JToken.Parse(responseContent)
                .ToObject<T>();

            return (dto, response.StatusCode);
        }
    }
}
