using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieRelatedLoanAmortizationType
    {
        [EnumMember(Value = "Adjustable Rate")]
        AdjustableRate = 0,
        Fixed = 1,
        [EnumMember(Value = "Graduated Payment ARM")]
        GraduatedPaymentARM = 2,
        [EnumMember(Value = "Graduated Payment Mortgage")]
        GraduatedPaymentMortgage = 3,
        [EnumMember(Value = "Growing Equity Mortgage")]
        GrowingEquityMortgage = 4,
        Step = 5
    }
}