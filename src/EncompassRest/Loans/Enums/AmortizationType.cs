using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AmortizationType
    {
        Fixed = 0,
        GraduatedPaymentMortgage = 1,
        AdjustableRate = 2,
        OtherAmortizationType = 3
    }
}