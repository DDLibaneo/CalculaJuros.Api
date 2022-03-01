using CalculaJuros.Api.Integration.Tests;
using System;

namespace CommonFixture
{
    public class CommonFixture
    {
        public CalculaJurosApiFixture CalculaJurosApiFixture { get; set; }

        public CommonFixture()
        {
            CalculaJurosApiFixture = new CalculaJurosApiFixture();
        }
    }
}
