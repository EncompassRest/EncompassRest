using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// TypeOfPurchaser
    /// </summary>
    public enum TypeOfPurchaser
    {
        /// <summary>
        /// 0. Not applicable
        /// </summary>
        [Description("0. Not applicable")]
        [EnumMember(Value = "Loan was not originated")]
        LoanWasNotOriginated = 0,
        /// <summary>
        /// 1. Fannie Mae
        /// </summary>
        [Description("1. Fannie Mae")]
        FNMA = 1,
        /// <summary>
        /// 2. Ginnie Mae
        /// </summary>
        [Description("2. Ginnie Mae")]
        GNMA = 2,
        /// <summary>
        /// 3. Freddie Mac
        /// </summary>
        [Description("3. Freddie Mac")]
        FHLMC = 3,
        /// <summary>
        /// 4. Farmer Mac
        /// </summary>
        [Description("4. Farmer Mac")]
        FAMC = 4,
        /// <summary>
        /// 5. Private securitizer
        /// </summary>
        [Description("5. Private securitizer")]
        [EnumMember(Value = "Private Securitization")]
        PrivateSecuritization = 5,
        /// <summary>
        /// 6. Commercial bank, savings bank, or savings association
        /// </summary>
        [Description("6. Commercial bank, savings bank, or savings association")]
        [EnumMember(Value = "Savings Bank")]
        SavingsBank = 6,
        /// <summary>
        /// 71. Credit union, mortgage company, or finance company
        /// </summary>
        [Description("71. Credit union, mortgage company, or finance company")]
        [EnumMember(Value = "Credit union, mortgage company, or finance company")]
        CreditUnionMortgageCompanyOrFinanceCompany = 7,
        /// <summary>
        /// 72. Life insurance company
        /// </summary>
        [Description("72. Life insurance company")]
        [EnumMember(Value = "Life Insurance Co.")]
        LifeInsuranceCo = 8,
        /// <summary>
        /// 8. Affiliate institution
        /// </summary>
        [Description("8. Affiliate institution")]
        [EnumMember(Value = "Affiliate Institution")]
        AffiliateInstitution = 9,
        /// <summary>
        /// 9. Other type of purchaser
        /// </summary>
        [Description("9. Other type of purchaser")]
        [EnumMember(Value = "Other type of purchaser")]
        OtherTypeOfPurchaser = 10
    }
}