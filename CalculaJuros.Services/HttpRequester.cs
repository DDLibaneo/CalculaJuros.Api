using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJuros.Services
{
    public interface IHttpRequester
    {
        Task<HttpResponseMessage> GetAsync();
    }

    public class HttpRequester : IHttpRequester
    {
        public Task<HttpResponseMessage> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
