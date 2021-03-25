using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.Configuration
{
    public class HttpClientOptions
    {

        public Uri? BaseAddress { get; set; }


        public HttpClientCompressionHandlerOptions CompressionOptions { get; set; }
    }
}
