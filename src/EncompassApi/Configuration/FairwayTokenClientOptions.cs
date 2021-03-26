namespace EncompassApi.Configuration
{
    public class FairwayTokenClientOptions : BaseHttpClientOptions
    {
        public const string FairwayTokenClient = "FairwayTokenClient";

        public string HostKey { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
