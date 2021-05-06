using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.v1.Flood
{
    /// <summary>
    /// FloodOptions
    /// </summary>
    public sealed class FloodOptions : ServiceOptions
    {
        private StringEnumValue<FloodProductNameAlt> _productName;

        /// <summary>
        /// The type of Flood service request being placed.
        /// </summary>
        public new StringEnumValue<FloodRequestType> RequestType => base.RequestType;

        /// <summary>
        /// The product details object contains information about the Flood product to order.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FloodProductDetails? ProductDetails { get; set; }

        /// <summary>
        /// The ServiceLink Account identifier for the servicer to whom the Flood certification is being transfered to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NewServicerAccountId { get; set; }

        /// <summary>
        /// Reference to a previously placed service request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ReferenceTransactionId { get; set; }

        /// <summary>
        /// Name of the Flood product being requested.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<FloodProductNameAlt> ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                ProductIdentifier = value.EnumValue?.AsString(EnumFormat.Description) ?? ProductIdentifier;
            }
        }

        /// <summary>
        /// Product code corresponding to the Flood product being requested.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ProductIdentifier { get; set; }

        /// <summary>
        /// FloodOptions constructor.
        /// </summary>
        /// <param name="requestType">The type of Flood service request being placed.</param>
        public FloodOptions(FloodRequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue()!)
        {
        }

        /// <summary>
        /// FloodOptions constructor.
        /// </summary>
        /// <param name="requestType">The type of Flood service request being placed.</param>
        public FloodOptions(string requestType)
            : base(requestType)
        {
        }
    }
}