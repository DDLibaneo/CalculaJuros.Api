using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJuros.Services
{

    public interface IHttpRequester
    {
        Task<HttpResponseMessage> GetLastJuroAsync();
    }

    public class HttpRequester : IHttpRequester
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddressJuroApi;
        private readonly string _pathGetLastJuro;

        public HttpRequester(IHttpRequesterOptions options, HttpClient httpClient)
        {
            _baseAddressJuroApi = options.UriJurosApi;
            _pathGetLastJuro = options.PathGetLastJuro;
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetLastJuroAsync()
        {
            var baseAddress = _baseAddressJuroApi;
            var pathLastJuro = _pathGetLastJuro;

            var request = new HttpRequestMessage()
            {
               Method = HttpMethod.Get,
               RequestUri = new Uri($"{baseAddress}/{pathLastJuro}")
            };

            var response = await _httpClient.SendAsync(request);

            return response;
        }
    }
}
