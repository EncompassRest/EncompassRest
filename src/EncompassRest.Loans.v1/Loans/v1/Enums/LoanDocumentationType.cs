using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LoanDocumentationType
    /// </summary>
    public enum LoanDocumentationType
    {
        /// <summary>
        /// (A) Alternative
        /// </summary>
        [Description("(A) Alternative")]
        Alternative = 0,
        /// <summary>
        /// (F) Full Documentation
        /// </summary>
        [Description("(F) Full Documentation")]
        FullDocumentation = 1,
        /// <summary>
        /// (R) Reduced
        /// </summary>
        [Description("(R) Reduced")]
        Reduced = 2,
        /// <summary>
        /// (B) Streamline Refinance
        /// </summary>
        [Description("(B) Streamline Refinance")]
        StreamlineRefinance = 3,
        /// <summary>
        /// (C) No Documentation
        /// </summary>
        [Description("(C) No Documentation")]
        NoDocumentation = 4,
        /// <summary>
        /// (D) No Ratio
        /// </summary>
        [Description("(D) No Ratio")]
        NoRatio = 5,
        /// <summary>
        /// (E) Limited Documentation
        /// </summary>
        [Description("(E) Limited Documentation")]
        LimitedDocumentation = 6,
        /// <summary>
        /// (U) No Income, No Employment, and No Assets on 1003
        /// </summary>
        [Description("(U) No Income, No Employment, and No Assets on 1003")]
        NoIncomeNoEmploymentNoAssetsOn1003 = 7,
        /// <summary>
        /// (G) No Income and No Assets on 1003
        /// </summary>
        [Description("(G) No Income and No Assets on 1003")]
        NoDepositVerificationEmploymentVerificationOrIncomeVerification = 8,
        /// <summary>
        /// (H) No Assets on 1003
        /// </summary>
        [Description("(H) No Assets on 1003")]
        NoDepositVerification = 9,
        /// <summary>
        /// (I) No Income and No Employment on 1003
        /// </summary>
        [Description("(I) No Income and No Employment on 1003")]
        NoEmploymentVerificationOrIncomeVerification = 10,
        /// <summary>
        /// (J) No Income on 1003
        /// </summary>
        [Description("(J) No Income on 1003")]
        NoIncomeOn1003 = 11,
        /// <summary>
        /// (K) No Verification of Stated Income, Employment, or Assets
        /// </summary>
        [Description("(K) No Verification of Stated Income, Employment, or Assets")]
        NoVerificationOfStatedIncomeEmploymentOrAssets = 12,
        /// <summary>
        /// (L) No Verification of Stated Income or Assets
        /// </summary>
        [Description("(L) No Verification of Stated Income or Assets")]
        NoVerificationOfStatedIncomeOrAssets = 13,
        /// <summary>
        /// (M) No Verification of Stated Assets
        /// </summary>
        [Description("(M) No Verification of Stated Assets")]
        NoVerificationOfStatedAssets = 14,
        /// <summary>
        /// (N) No Verfication of Stated Income or Employment
        /// </summary>
        [Description("(N) No Verfication of Stated Income or Employment")]
        NoVerificationOfStatedIncomeOrEmployment = 15,
        /// <summary>
        /// (O) No Verification of Stated Income
        /// </summary>
        [Description("(O) No Verification of Stated Income")]
        NoVerificationOfStatedIncome = 16,
        /// <summary>
        /// (P) Verbal Verification of Employment(VVOE)
        /// </summary>
        [Description("(P) Verbal Verification of Employment(VVOE)")]
        VerbalVerificationOfEmployment = 17,
        /// <summary>
        /// (Q) One paystub
        /// </summary>
        [Description("(Q) One paystub")]
        OnePaystub = 18,
        /// <summary>
        /// (S) One paystub and VVOE
        /// </summary>
        [Description("(S) One paystub and VVOE")]
        OnePaystubAndVerbalVerificationOfEmployment = 19,
        /// <summary>
        /// (T) One paystub and one W-2 and VVOE or one year 1040
        /// </summary>
        [Description("(T) One paystub and one W-2 and VVOE or one year 1040")]
        OnePaystubAndOneW2AndVerbalVerificationOfEmploymentOrOneYear1040 = 20
    }
}