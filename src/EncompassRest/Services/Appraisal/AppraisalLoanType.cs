using System.Runtime.Serialization;

namespace EncompassRest.Services.Appraisal
{
    /// <summary>
    /// AppraisalLoanType
    /// </summary>
    public enum AppraisalLoanType
    {
        /// <summary>
        /// All In One
        /// </summary>
        [EnumMember(Value = "All In One")]
        AllInOne = 0,
        /// <summary>
        /// Alt QM Agency
        /// </summary>
        [EnumMember(Value = "Alt QM Agency")]
        AltQMAgency = 1,
        /// <summary>
        /// Alt QM Income
        /// </summary>
        [EnumMember(Value = "Alt QM Income")]
        AltQMIncome = 2,
        /// <summary>
        /// Alt QM Investor
        /// </summary>
        [EnumMember(Value = "Alt QM Investor")]
        AltQMInvestor = 3,
        /// <summary>
        /// Alt QM Jumbo
        /// </summary>
        [EnumMember(Value = "Alt QM Jumbo")]
        AltQMJumbo = 4,
        /// <summary>
        /// CMBS
        /// </summary>
        CMBS = 5,
        /// <summary>
        /// CMHC
        /// </summary>
        CMHC = 6,
        /// <summary>
        /// Commercial - other
        /// </summary>
        [EnumMember(Value = "Commercial - other")]
        CommercialOther = 7,
        /// <summary>
        /// Construction financing
        /// </summary>
        [EnumMember(Value = "Construction financing")]
        ConstructionFinancing = 8,
        /// <summary>
        /// Conventional
        /// </summary>
        Conventional = 9,
        /// <summary>
        /// FHA
        /// </summary>
        FHA = 10,
        /// <summary>
        /// FHA 203(k) Limited
        /// </summary>
        [EnumMember(Value = "FHA 203(k) Limited")]
        FHA203KLimited = 11,
        /// <summary>
        /// FHA 203(k) Standard
        /// </summary>
        [EnumMember(Value = "FHA 203(k) Standard")]
        FHA203KStandard = 12,
        /// <summary>
        /// FHA 223(f)
        /// </summary>
        [EnumMember(Value = "FHA 223(f)")]
        FHA223F = 13,
        /// <summary>
        /// FSA/RHS/FmHA"
        /// </summary>
        [EnumMember(Value = "FSA/RHS/FmHA")]
        FSA_RHS_FmHA = 14,
        /// <summary>
        /// HARP 2
        /// </summary>
        [EnumMember(Value = "HARP 2")]
        HARP2 = 15,
        /// <summary>
        /// Home Equity
        /// </summary>
        [EnumMember(Value = "Home Equity")]
        HomeEquity = 16,
        /// <summary>
        /// Home Ownership Accel
        /// </summary>
        [EnumMember(Value = "Home Ownership Accel")]
        HomeOwnershipAccel = 17,
        /// <summary>
        /// HomeStyle Renovation
        /// </summary>
        [EnumMember(Value = "HomeStyle Renovation")]
        HomeStyleRenovation = 18,
        /// <summary>
        /// Jumbo
        /// </summary>
        Jumbo = 19,
        /// <summary>
        /// Mezzanine financing
        /// </summary>
        [EnumMember(Value = "Mezzanine financing")]
        MezzanineFinancing = 20,
        /// <summary>
        /// One Time Close
        /// </summary>
        [EnumMember(Value = "One Time Close")]
        OneTimeClose = 21,
        /// <summary>
        /// Other
        /// </summary>
        Other = 22,
        /// <summary>
        /// Reverse Mortgage
        /// </summary>
        [EnumMember(Value = "Reverse Mortgage")]
        ReverseMortgage = 23,
        /// <summary>
        /// SBA 504
        /// </summary>
        [EnumMember(Value = "SBA 504")]
        SBA504 = 24,
        /// <summary>
        /// SBA 7A
        /// </summary>
        [EnumMember(Value = "SBA 7A")]
        SBA7A = 25,
        /// <summary>
        /// Section 184
        /// </summary>
        [EnumMember(Value = "Section 184")]
        Section184 = 26,
        /// <summary>
        /// USDA
        /// </summary>
        USDA = 27,
        /// <summary>
        /// VA
        /// </summary>
        VA = 28
    }
}