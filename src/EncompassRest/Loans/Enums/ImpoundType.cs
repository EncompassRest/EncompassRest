using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ImpoundType
    {
        [EnumMember(Value = "Taxes and Insurance")]
        TaxesAndInsurance = 0,
        [EnumMember(Value = "Taxes only")]
        TaxesOnly = 1,
        [EnumMember(Value = "Insurance only")]
        InsuranceOnly = 2,
        [EnumMember(Value = "No Impounds")]
        NoImpounds = 3
    }
}