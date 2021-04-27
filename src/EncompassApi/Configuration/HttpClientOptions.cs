using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.Configuration
{
    public class HttpClientOptions : IHttpClientOptions
    {
        public HttpClientCompressionHandlerOptions CompressionOptions { get; set; }

        public ClientParameters ClientParameters { get; set; }

        public BaseHttpClientOptions TokenClientOptions { get; set; }

        public EncompassHttpResponseHeaderLoggerOptions EncompassHttpResponseHeaderLoggerOptions { get; set; }
    }
}
