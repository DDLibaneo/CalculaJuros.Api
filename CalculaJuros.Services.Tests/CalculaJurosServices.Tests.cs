using CalculaJuros.Services;
using Moq;
using System;
using Xunit;

namespace CalculaJuros.Services.Tests
{
    public class CalculaJurosServicesTests
    {
        private readonly CalculaJurosService _service;
        private readonly Mock<IHttpRequester> _httpRequester = new Mock<IHttpRequester>();

        public CalculaJurosServicesTests()
        {
            _service = new CalculaJurosService(_httpRequester.Object);
        }

        [Fact(DisplayName = "CalcularJuros  - [Success]")]
        public void CalcularJuros_Success()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
