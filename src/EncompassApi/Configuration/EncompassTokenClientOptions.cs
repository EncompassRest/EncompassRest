namespace EncompassApi.Configuration
{
    public class EncompassTokenClientOptions : BaseHttpClientOptions
    {
        public const string EncompassTokenClient = "EncompassTokenClient";

        public string AuthKey { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EncompassInstanceId { get; set; }
    }
}
