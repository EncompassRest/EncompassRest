using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class TokenServiceClientOptions
    {
        public const string TokenServiceClient = "TokenServiceClient";

        public string AuthKey { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EncompassInstanceId { get; set; }
        public string BaseUrl { get; set; }
    }
}
