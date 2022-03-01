using CalculaJuros.Models;
using Microsoft.AspNetCore.Http;
using System.Net;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CalculaJuros.Services
{

    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly IHttpRequester _httpRequester;

        public CalculaJurosService(IHttpRequester httpRequester)
        {
            _httpRequester = httpRequester;
        }

        public async Task<decimal> CalculaJuro(decimal valorInicial, int tempoMeses)
        {
            var response = await _httpRequester.GetLastJuroAsync();

            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception("Request error.");
            
            var responseContent = await response.Content.ReadAsStringAsync();

            var juroDto = JToken.Parse(responseContent)
                .ToObject<JuroDto>();

            return juroDto.Taxa;
        }
    }
}
