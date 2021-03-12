using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class TokenResponse
    {
        /// <summary>
        /// name of the token
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// error message
        /// </summary>
        public string errorMessage { get; set; }
        /// <summary>
        /// status code
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// description
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// request id
        /// </summary>
        public string requestId { get; set; }
        /// <summary>
        /// access token
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// token type
        /// </summary>
        public string token_type { get; set; }
    }
}
