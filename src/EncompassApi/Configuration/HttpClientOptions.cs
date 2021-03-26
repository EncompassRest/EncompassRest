using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.Configuration
{
    public class HttpClientOptions
    {


        public HttpClientCompressionHandlerOptions CompressionOptions { get; set; }

        public ClientParameters ClientParameters { get; set; }

        public EncompassTokenClientOptions TokenClientOptions { get; set; }
    }
}
