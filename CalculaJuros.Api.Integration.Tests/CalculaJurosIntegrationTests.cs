using CalculaJuros.Api.Integration.Tests.Environment;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Api.Integration.Tests
{
    public class CalculaJurosIntegrationTests : IClassFixture<CommonFixture>
    {
        private readonly CalculaJurosApiFixture _apiFixture;

        public CalculaJurosIntegrationTests(CommonFixture commonFixture)
        {
            _apiFixture = commonFixture.CalculaJurosApiFixture;
        }

        [Fact(DisplayName = "CalcularJuros - [Success] - Juros são calculados e retornados corretamente.")]
        public async Task CalcularJuros_Success()
        {
            // Arrange
            var valorInicial = 100m;
            var meses = 5;
            var valorFinal = 105.10m;

            // Act
            var (responseObject, statusCode) = await _apiFixture.GetInApiAsync<decimal>($"/api/calculaJuros?valorInicial={valorInicial}&meses={meses}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, statusCode);
            Assert.Equal(valorFinal, responseObject);
        }
    }
}
