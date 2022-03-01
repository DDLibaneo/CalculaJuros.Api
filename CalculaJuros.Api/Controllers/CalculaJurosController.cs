using CalculaJuros.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJuros.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _calculaJurosService;

        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            _calculaJurosService = calculaJurosService;
        }

        [HttpGet("calculaJuros")]
        public async Task<IActionResult> CalculaJuros(
            [FromQuery]decimal valorInicial, 
            [FromQuery]int meses)
        {
            var result = await _calculaJurosService.CalculaJuro(valorInicial, meses);
            return Ok(result);
        }
    }
}
