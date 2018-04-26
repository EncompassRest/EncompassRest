using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Appraisal
{
    public enum AppraisalLoanType
    {
        [EnumMember(Value = "All In One")]
        AllInOne = 0,
        [EnumMember(Value = "Alt QM Agency")]
        AltQMAgency = 1,
        [EnumMember(Value = "Alt QM Income")]
        AltQMIncome = 2,
        [EnumMember(Value = "Alt QM Investor")]
        AltQMInvestor = 3,
        [EnumMember(Value = "Alt QM Jumbo")]
        AltQMJumbo = 4,
        CMBS = 5,
        CMHC = 6,
        [EnumMember(Value = "Commercial - other")]
        CommercialOther = 7,
        [EnumMember(Value = "Construction financing")]
        CommericalFinancing = 8,
        Conventional = 9,
        FHA = 10,
        [EnumMember(Value = "FHA 203(k) Limited")]
        FHA203KLimited = 11,
        [EnumMember(Value = "FHA 203(k) Standard")]
        FHA203KStandard = 12,
        [EnumMember(Value = "FHA 223(f)")]
        FHA223F = 13,
        [EnumMember(Value = "FSA /RHS/FmHA")]
        FSA_RHS_FmHA = 14,
        [EnumMember(Value = "HARP 2")]
        HARP2 = 15,
        [EnumMember(Value = "Home Equity")]
        HomeEquity = 16,
        [EnumMember(Value = "Home Ownership Accel")]
        HomeOwnershipAccel = 17,
        [EnumMember(Value = "HomeStyle Renovation")]
        HomeStyleRenovation = 18,
        Jumbo = 19,
        [EnumMember(Value = "Mezzanine financing")]
        MezzanineFinancing = 20,
        [EnumMember(Value = "One Time Close")]
        OneTimeClose = 21,
        Other = 22,
        [EnumMember(Value = "Reverse Mortgage")]
        ReverseMortgage = 23,
        [EnumMember(Value = "SBA 504")]
        SBA504 = 24,
        [EnumMember(Value = "SBA 7A")]
        SBA7A = 25,
        [EnumMember(Value = "Section 184")]
        Section184 = 26,
        USDA = 27,
        VA = 28
    }
}