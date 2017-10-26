using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum STDDownPaymentSectionRemark
    {
        K = 0,
        L = 1,
        [EnumMember(Value = "K and L")]
        KAndL = 2
    }
}