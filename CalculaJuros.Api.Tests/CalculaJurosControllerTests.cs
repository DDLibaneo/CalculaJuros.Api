using CalculaJuros.Api.Controllers;
using CalculaJuros.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Api.Tests
{
    public class CalculaJurosControllerTests
    {
        private readonly CalculaJurosController _calculaJurosController;
        private readonly Mock<ICalculaJurosService> _calculaJurosService = new Mock<ICalculaJurosService>();

        public CalculaJurosControllerTests()
        {
            _calculaJurosController = new CalculaJurosController(_calculaJurosService.Object);
        }

        [Fact(DisplayName = "CalcularJuros - [Success]")]
        public async Task CalcularJuros_Success()
        {
            // Arrange
            var valorInicial = 100m;
            var meses = 5;
            var valorFinal = 105.10m;

            _calculaJurosService.Setup(c => c.CalculaJuro(valorInicial, meses))
                .ReturnsAsync(valorFinal);

            // Act
            var result = await _calculaJurosController.CalculaJuros(valorInicial, meses);

            // Assert
            var objectResult = Assert.IsType<OkObjectResult>(result);

            Assert.Equal(StatusCodes.Status200OK, objectResult.StatusCode);
            Assert.Equal(valorFinal, objectResult.Value);

            var failMessage = "CalculaJuro should be called once.";
            _calculaJurosService.Verify(c => c.CalculaJuro(valorInicial, meses), Times.Once, failMessage);
            
        }
    }
}
