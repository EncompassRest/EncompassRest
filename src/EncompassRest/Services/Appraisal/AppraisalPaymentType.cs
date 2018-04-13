using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Appraisal
{
    public enum AppraisalPaymentType
    {
        Check = 0,
        [EnumMember(Value = "C.O.D.")]
        COD = 1,
        [EnumMember(Value = "Credit Card")]
        CreditCard = 2,
        [EnumMember(Value = "Money order")]
        MoneyOrder = 3,
        [EnumMember(Value = "Net 30")]
        Net30 = 4,
        PayPal = 5,
        Invoice = 6,
        [EnumMember(Value = "Deferred CC")]
        DeferredCC = 7
    }
}