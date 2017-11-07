using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum OrgTyp
    {
        [EnumMember(Value = "a Banking Corporation")]
        ABankingCorporation = 0,
        [EnumMember(Value = "a Chartered Bank")]
        ACharteredBank = 1,
        [EnumMember(Value = "a Corporation")]
        ACorporation = 2,
        [EnumMember(Value = "a Federal Association")]
        AFederalAssociation = 3,
        [EnumMember(Value = "a Federal Bank")]
        AFederalBank = 4,
        [EnumMember(Value = "a Federal Credit Union")]
        AFederalCreditUnion = 5,
        [EnumMember(Value = "a Federal Savings Association")]
        AFederalSavingsAssociation = 6,
        [EnumMember(Value = "a Federal Savings Bank")]
        AFederalSavingsBank = 7,
        [EnumMember(Value = "a Federally Chartered Thrift")]
        AFederallyCharteredThrift = 8,
        [EnumMember(Value = "a Federally Chartered Savings Bank")]
        AFederallyCharteredSavingsBank = 9,
        [EnumMember(Value = "a General Partnership")]
        AGeneralPartnership = 10,
        [EnumMember(Value = "a Limited Liability Corporation")]
        ALimitedLiabilityCorporation = 11,
        [EnumMember(Value = "a Limited Partnership")]
        ALimitedPartnership = 12,
        [EnumMember(Value = "a Mutual Savings Bank")]
        AMutualSavingsBank = 13,
        [EnumMember(Value = "a National Association")]
        ANationalAssociation = 14,
        [EnumMember(Value = "a National Bank")]
        ANationalBank = 15,
        [EnumMember(Value = "a National Banking Association")]
        ANationalBankingAssociation = 16,
        [EnumMember(Value = "a Partnership")]
        APartnership = 17,
        [EnumMember(Value = "a Professional Association")]
        AProfessionalAssociation = 18,
        [EnumMember(Value = "a Professional Corporation")]
        AProfessionalCorporation = 19,
        [EnumMember(Value = "a Proprietorship")]
        AProprietorship = 20,
        [EnumMember(Value = "a Sole Proprietorship")]
        ASoleProprietorship = 21,
        [EnumMember(Value = "a Savings Bank")]
        ASavingsBank = 22,
        [EnumMember(Value = "a State Bank")]
        AStateBank = 23,
        [EnumMember(Value = "a State Banking Association")]
        AStateBankingAssociation = 24,
        [EnumMember(Value = "a State Chartered Credit Union")]
        AStateCharteredCreditUnion = 25,
        [EnumMember(Value = "a State Chartered Bank")]
        AStateCharteredBank = 26,
        [EnumMember(Value = "a State Savings Bank")]
        AStateSavingsBank = 27,
        [EnumMember(Value = "a Sub S Corporation")]
        ASubSCorporation = 28,
        [EnumMember(Value = "an S Corporation")]
        AnSCorporation = 29
    }
}