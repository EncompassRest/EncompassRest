using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// OrgTyp
/// </summary>
public enum OrgTyp
{
    /// <summary>
    /// a Banking Corporation
    /// </summary>
    [EnumMember(Value = "a Banking Corporation")]
    ABankingCorporation = 0,
    /// <summary>
    /// a Chartered Bank
    /// </summary>
    [EnumMember(Value = "a Chartered Bank")]
    ACharteredBank = 1,
    /// <summary>
    /// a Corporation
    /// </summary>
    [EnumMember(Value = "a Corporation")]
    ACorporation = 2,
    /// <summary>
    /// a Federal Association
    /// </summary>
    [EnumMember(Value = "a Federal Association")]
    AFederalAssociation = 3,
    /// <summary>
    /// a Federal Bank
    /// </summary>
    [EnumMember(Value = "a Federal Bank")]
    AFederalBank = 4,
    /// <summary>
    /// a Federal Credit Union
    /// </summary>
    [EnumMember(Value = "a Federal Credit Union")]
    AFederalCreditUnion = 5,
    /// <summary>
    /// a Federal Savings Association
    /// </summary>
    [EnumMember(Value = "a Federal Savings Association")]
    AFederalSavingsAssociation = 6,
    /// <summary>
    /// a Federal Savings Bank
    /// </summary>
    [EnumMember(Value = "a Federal Savings Bank")]
    AFederalSavingsBank = 7,
    /// <summary>
    /// a Federally Chartered Thrift
    /// </summary>
    [EnumMember(Value = "a Federally Chartered Thrift")]
    AFederallyCharteredThrift = 8,
    /// <summary>
    /// a Federally Chartered Savings Bank
    /// </summary>
    [EnumMember(Value = "a Federally Chartered Savings Bank")]
    AFederallyCharteredSavingsBank = 9,
    /// <summary>
    /// a General Partnership
    /// </summary>
    [EnumMember(Value = "a General Partnership")]
    AGeneralPartnership = 10,
    /// <summary>
    /// a Limited Liability Corporation
    /// </summary>
    [EnumMember(Value = "a Limited Liability Corporation")]
    ALimitedLiabilityCorporation = 11,
    /// <summary>
    /// a Limited Partnership
    /// </summary>
    [EnumMember(Value = "a Limited Partnership")]
    ALimitedPartnership = 12,
    /// <summary>
    /// a Mutual Savings Bank
    /// </summary>
    [EnumMember(Value = "a Mutual Savings Bank")]
    AMutualSavingsBank = 13,
    /// <summary>
    /// a National Association
    /// </summary>
    [EnumMember(Value = "a National Association")]
    ANationalAssociation = 14,
    /// <summary>
    /// a National Bank
    /// </summary>
    [EnumMember(Value = "a National Bank")]
    ANationalBank = 15,
    /// <summary>
    /// a National Banking Association
    /// </summary>
    [EnumMember(Value = "a National Banking Association")]
    ANationalBankingAssociation = 16,
    /// <summary>
    /// a Partnership
    /// </summary>
    [EnumMember(Value = "a Partnership")]
    APartnership = 17,
    /// <summary>
    /// a Professional Association
    /// </summary>
    [EnumMember(Value = "a Professional Association")]
    AProfessionalAssociation = 18,
    /// <summary>
    /// a Professional Corporation
    /// </summary>
    [EnumMember(Value = "a Professional Corporation")]
    AProfessionalCorporation = 19,
    /// <summary>
    /// a Proprietorship
    /// </summary>
    [EnumMember(Value = "a Proprietorship")]
    AProprietorship = 20,
    /// <summary>
    /// a Sole Proprietorship
    /// </summary>
    [EnumMember(Value = "a Sole Proprietorship")]
    ASoleProprietorship = 21,
    /// <summary>
    /// a Savings Bank
    /// </summary>
    [EnumMember(Value = "a Savings Bank")]
    ASavingsBank = 22,
    /// <summary>
    /// a State Bank
    /// </summary>
    [EnumMember(Value = "a State Bank")]
    AStateBank = 23,
    /// <summary>
    /// a State Banking Association
    /// </summary>
    [EnumMember(Value = "a State Banking Association")]
    AStateBankingAssociation = 24,
    /// <summary>
    /// a State Chartered Credit Union
    /// </summary>
    [EnumMember(Value = "a State Chartered Credit Union")]
    AStateCharteredCreditUnion = 25,
    /// <summary>
    /// a State Chartered Bank
    /// </summary>
    [EnumMember(Value = "a State Chartered Bank")]
    AStateCharteredBank = 26,
    /// <summary>
    /// a State Savings Bank
    /// </summary>
    [EnumMember(Value = "a State Savings Bank")]
    AStateSavingsBank = 27,
    /// <summary>
    /// a Sub S Corporation
    /// </summary>
    [EnumMember(Value = "a Sub S Corporation")]
    ASubSCorporation = 28,
    /// <summary>
    /// an S Corporation
    /// </summary>
    [EnumMember(Value = "an S Corporation")]
    AnSCorporation = 29
}