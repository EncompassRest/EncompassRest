using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Appraisal
{
    public enum AppraisalRequestType
    {
        [EnumMember(Value = "feeQuote")]
        FeeQuote = 0,
        [EnumMember(Value = "newOrder")]
        NewOrder = 1,
        [EnumMember(Value = "checkStatus")]
        CheckStatus = 2,
        [EnumMember(Value = "existingOrder")]
        ExistingOrder = 3
    }
}