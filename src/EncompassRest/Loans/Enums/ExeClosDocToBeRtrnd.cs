using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ExeClosDocToBeRtrnd
    {
        [EnumMember(Value = "AFTER SIGNING OF LOAN DOCUMENTS")]
        AFTERSIGNINGOFLOANDOCUMENTS = 0,
        [EnumMember(Value = "AFTER DISBURSEMENT OF LOAN FUNDS")]
        AFTERDISBURSEMENTOFLOANFUNDS = 1,
        [EnumMember(Value = "AFTER DISBURSEMENT DATE")]
        AFTERDISBURSEMENTDATE = 2,
        [EnumMember(Value = "PRIOR TO DISBURSEMENT OF LOAN FUNDS")]
        PRIORTODISBURSEMENTOFLOANFUNDS = 3
    }
}