using CalculaJuros.Api.Integration.Tests.Environment;
using System;
using Xunit;

namespace CalculaJuros.Api.Integration.Tests
{
    public class CalculaJurosIntegrationTests
    {
        private readonly CalculaJurosApiFixture _apiFixture;

        public CalculaJurosIntegrationTests(CommonFixture commonFixture)
        {
            _apiFixture = commonFixture.CalculaJurosApiFixture;
        }

        [Fact(DisplayName = "CalcularJuros - [Success] - Juros são calculados e retornados corretamente.")]
        public void CalcularJuros_Success()
        {
            // Arrange
            
            // Act

            // Assert
        }
    }
}
