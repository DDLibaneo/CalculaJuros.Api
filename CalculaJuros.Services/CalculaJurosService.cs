using System;
using System.Threading.Tasks;

namespace CalculaJuros.Services
{

    public class CalculaJurosService : ICalculaJurosService
    {
        private readonly IHttpRequester _httpRequester;

        public CalculaJurosService(IHttpRequester httpRequester)
        {
            _httpRequester = httpRequester;
        }

        public Task<decimal> CalculaJuro(decimal valorInicial, int tempoMeses)
        {
            throw new NotImplementedException();
        }
    }
}
