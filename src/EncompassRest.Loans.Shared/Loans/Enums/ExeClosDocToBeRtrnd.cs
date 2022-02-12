using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ExeClosDocToBeRtrnd
/// </summary>
public enum ExeClosDocToBeRtrnd
{
    /// <summary>
    /// AFTER SIGNING OF LOAN DOCUMENTS
    /// </summary>
    [EnumMember(Value = "AFTER SIGNING OF LOAN DOCUMENTS")]
    AFTERSIGNINGOFLOANDOCUMENTS = 0,
    /// <summary>
    /// AFTER DISBURSEMENT OF LOAN FUNDS
    /// </summary>
    [EnumMember(Value = "AFTER DISBURSEMENT OF LOAN FUNDS")]
    AFTERDISBURSEMENTOFLOANFUNDS = 1,
    /// <summary>
    /// AFTER DISBURSEMENT DATE
    /// </summary>
    [EnumMember(Value = "AFTER DISBURSEMENT DATE")]
    AFTERDISBURSEMENTDATE = 2,
    /// <summary>
    /// PRIOR TO DISBURSEMENT OF LOAN FUNDS
    /// </summary>
    [EnumMember(Value = "PRIOR TO DISBURSEMENT OF LOAN FUNDS")]
    PRIORTODISBURSEMENTOFLOANFUNDS = 3
}