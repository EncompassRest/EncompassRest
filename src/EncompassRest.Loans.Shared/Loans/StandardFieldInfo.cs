using EncompassRest.Schema;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    internal sealed class StandardFieldInfo : FieldInfo
    {
        public string? ModelPathV1 { get; }

        public string? ModelPathV3 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        [JsonIgnore]
        public LoanFieldFormat? NonSerializedFormat { get; set; }

        public StandardFieldInfo(string fieldId, string? modelPathV1, string? modelPathV3)
            : base(fieldId)
        {
            ModelPathV1 = modelPathV1;
            ModelPathV3 = modelPathV3;
        }
    }
}