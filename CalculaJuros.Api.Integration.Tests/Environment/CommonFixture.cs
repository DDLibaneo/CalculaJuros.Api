using CalculaJuros.Api.Integration.Tests;
using System;

namespace CalculaJuros.Api.Integration.Tests.Environment
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
