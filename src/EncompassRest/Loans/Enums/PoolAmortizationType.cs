using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PoolAmortizationType
    {
        AdjustableRate = 0,
        Fixed = 1,
        GraduatedPaymentARM = 2,
        GraduatedPaymentMortgage = 3,
        GrowingEquityMortgage = 4
    }
}