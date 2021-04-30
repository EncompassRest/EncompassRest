using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ProjectType
    /// </summary>
    public enum ProjectType
    {
        /// <summary>
        /// III Condo
        /// </summary>
        [Description("III Condo")]
        [EnumMember(Value = "A_IIICondominium")]
        AIIICondominium = 0,
        /// <summary>
        /// II Condo
        /// </summary>
        [Description("II Condo")]
        [EnumMember(Value = "B_IICondominium")]
        BIICondominium = 1,
        /// <summary>
        /// I Condo
        /// </summary>
        [Description("I Condo")]
        [EnumMember(Value = "C_ICondominium")]
        CICondominium = 2,
        /// <summary>
        /// One Cooperative
        /// </summary>
        [Description("One Cooperative")]
        OneCooperative = 3,
        /// <summary>
        /// Two Cooperative
        /// </summary>
        [Description("Two Cooperative")]
        TwoCooperative = 4,
        /// <summary>
        /// T Cooperative
        /// </summary>
        [Description("T Cooperative")]
        TCooperative = 5,
        /// <summary>
        /// E/PUD
        /// </summary>
        [Description("E/PUD")]
        [EnumMember(Value = "E_PUD")]
        EPUD = 6,
        /// <summary>
        /// F/PUD
        /// </summary>
        [Description("F/PUD")]
        [EnumMember(Value = "F_PUD")]
        FPUD = 7,
        /// <summary>
        /// T/PUD
        /// </summary>
        [Description("T/PUD")]
        [EnumMember(Value = "T_PUD")]
        TPUD = 8,
        /// <summary>
        /// III PUD
        /// </summary>
        [EnumMember(Value = "III PUD")]
        IIIPUD = 9,
        /// <summary>
        /// P/Limited Review New Detached
        /// </summary>
        [Description("P/Limited Review New Detached")]
        [EnumMember(Value = "P_LimitedReviewNew")]
        PLimitedReviewNew = 10,
        /// <summary>
        /// Q/Limited Review Est.
        /// </summary>
        [Description("Q/Limited Review Est.")]
        [EnumMember(Value = "Q_LimitedReviewEst")]
        QLimitedReviewEst = 11,
        /// <summary>
        /// R/Expedited New
        /// </summary>
        [Description("R/Expedited New")]
        [EnumMember(Value = "R_ExpeditedNew")]
        RExpeditedNew = 12,
        /// <summary>
        /// S/Expedited Est.
        /// </summary>
        [Description("S/Expedited Est.")]
        [EnumMember(Value = "S_ExpeditedEst")]
        SExpeditedEst = 13,
        /// <summary>
        /// T/Fannie Mae Review
        /// </summary>
        [Description("T/Fannie Mae Review")]
        [EnumMember(Value = "T_FannieMaeReview")]
        TFannieMaeReview = 14,
        /// <summary>
        /// U/FHA-approved
        /// </summary>
        [Description("U/FHA-approved")]
        [EnumMember(Value = "U_FHAapproved")]
        UFHAapproved = 15,
        /// <summary>
        /// V/Refi Plus
        /// </summary>
        [Description("V/Refi Plus")]
        [EnumMember(Value = "V_RefiPlus")]
        VRefiPlus = 16,
        /// <summary>
        /// Detached Project
        /// </summary>
        [Description("Detached Project")]
        DetachedProject = 17,
        /// <summary>
        /// 2-To-4-Unit Project
        /// </summary>
        [Description("2-To-4-Unit Project")]
        [EnumMember(Value = "2To4UnitProject")]
        n2To4UnitProject = 18,
        /// <summary>
        /// Reciprocal Review
        /// </summary>
        [Description("Reciprocal Review")]
        ReciprocalReview = 19,
        /// <summary>
        /// Approved FHA/VA Condominium Project Or Spot Loan
        /// </summary>
        [EnumMember(Value = "Approved FHA/VA Condominium Project Or Spot Loan")]
        ApprovedFHAVACondominiumProjectOrSpotLoan = 20,
        /// <summary>
        /// G/Not in a Project or Development
        /// </summary>
        [Description("G/Not in a Project or Development")]
        [EnumMember(Value = "G_NotInAProjectOrDevelopment")]
        GNotInAProjectOrDevelopment = 21,
        /// <summary>
        /// V/No Review-Site Condo
        /// </summary>
        [Description("V/No Review-Site Condo")]
        [EnumMember(Value = "V_NoReviewSiteCondo")]
        VNoReviewSiteCondo = 22,
        /// <summary>
        /// Freddie Mac: Exempt From Review
        /// </summary>
        [Description("Freddie Mac: Exempt From Review")]
        ExemptFromReview = 23,
        /// <summary>
        /// Fannie Mae: 1 Full Review - Co-op Project
        /// </summary>
        [Description("Fannie Mae: 1 Full Review - Co-op Project")]
        FullReviewCoopProject = 24,
        /// <summary>
        /// Fannie Mae: 2 Fannie Mae Review through PERS - Co-op Project
        /// </summary>
        [Description("Fannie Mae: 2 Fannie Mae Review through PERS - Co-op Project")]
        FannieMaeReviewPERSCoopProject = 25
    }
}