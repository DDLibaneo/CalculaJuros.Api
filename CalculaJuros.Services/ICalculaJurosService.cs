using System.Threading.Tasks;

namespace CalculaJuros.Services
{
    public interface ICalculaJurosService
    {
        Task<decimal> CalculaJuro(decimal valorInicial, int tempoMeses);
    }
}
