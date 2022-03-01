using CalculaJuros.Models;
using CalculaJuros.Services;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Services.Tests
{
    public class CalculaJurosServicesTests
    {
        private readonly CalculaJurosService _calculaJurosService;
        private readonly Mock<IHttpRequester> _httpRequester = new Mock<IHttpRequester>();

        public CalculaJurosServicesTests()
        {
            _calculaJurosService = new CalculaJurosService(_httpRequester.Object);
        }

        [Fact(DisplayName = "CalcularJuros  - [Success]")]
        public async Task CalcularJuros_Success()
        {
            // Arrange
            var valorInicial = 100m;
            var meses = 5;
            var juro = 0.1m;
            var valorFinal = 105.10m;

            var juroDto = new JuroDto
            {
                CreationDate = new DateTime(2022, 03, 01),
                Id = 6,
                Taxa = juro
            };

            var httpResponseMessage = new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(JToken.FromObject(juroDto).ToString())
            };

            _httpRequester.Setup(h => h.GetLastJuroAsync())
                .ReturnsAsync(httpResponseMessage);

            // Act
            var result = await _calculaJurosService.CalculaJuro(valorInicial, meses);

            // Assert
            Assert.IsType<decimal>(result);
            Assert.Equal(valorFinal, result);

            var failMessage = "GetLastJuroAsync should be called once.";
            _httpRequester.Verify(h => h.GetLastJuroAsync(), Times.Once, failMessage);
        }
    }
}
