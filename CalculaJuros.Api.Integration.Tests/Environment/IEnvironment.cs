using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CalculaJuros.Api.Integration.Tests.Environment
{
    public interface IEnvironment
    {
        HttpClient Client { get; }
    }
}
