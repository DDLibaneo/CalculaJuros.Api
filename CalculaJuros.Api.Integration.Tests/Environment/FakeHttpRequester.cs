using CalculaJuros.Models;
using CalculaJuros.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Integration.Tests.Environment
{
    public class FakeHttpRequester : IHttpRequester
    {
        public Task<HttpResponseMessage> GetLastJuroAsync()
        {
            var juro = 0.01m;

            var juroDto = new JuroDto
            {
                Id = 6,
                Taxa = juro,
                CreationDate = new DateTime(2022, 03, 01)
            };

            var httpResponseMessage = new HttpResponseMessage
            {
                Content = new StringContent(JToken.FromObject(juroDto).ToString())
            };

            return Task.FromResult(httpResponseMessage);
        }
    }
}