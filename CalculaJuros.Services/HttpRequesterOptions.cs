using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaJuros.Services
{
    public interface IHttpRequesterOptions
    {
        string UriJurosApi { get; }
        string PathGetLastJuro { get; }
    }

    public class HttpRequesterOptions : IHttpRequesterOptions
    {
        private readonly string _uriJurosApi;
        private readonly string _pathGetLastJuro;

        private readonly string JUROS_API_ENDPOINT = "JUROS_API_ENDPOINT";
        private readonly string JUROS_API_ENDPOINT_GETLASTJURO_PATH = "JUROS_API_ENDPOINT_GETLASTJURO_PATH";

        private readonly string VARIABLE_NOTFOUND_MESSAGE = "Environment variable was not provided.";

        public HttpRequesterOptions()
        {
            _uriJurosApi = Environment.GetEnvironmentVariable(JUROS_API_ENDPOINT);
            _pathGetLastJuro = Environment.GetEnvironmentVariable(JUROS_API_ENDPOINT_GETLASTJURO_PATH);
        }

        public string UriJurosApi
        {
            get 
            { 
                return _uriJurosApi
                    ?? throw new Exception(VARIABLE_NOTFOUND_MESSAGE);
            }
        }

        public string PathGetLastJuro
        {
            get
            {
                return _pathGetLastJuro
                    ?? throw new Exception(VARIABLE_NOTFOUND_MESSAGE);
            }
        }
    }
}
