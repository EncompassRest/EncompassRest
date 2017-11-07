using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ProjectType
    {
        [EnumMember(Value = "A_IIICondominium")]
        AIIICondominium = 0,
        [EnumMember(Value = "B_IICondominium")]
        BIICondominium = 1,
        [EnumMember(Value = "C_ICondominium")]
        CICondominium = 2,
        OneCooperative = 3,
        TwoCooperative = 4,
        TCooperative = 5,
        [EnumMember(Value = "E_PUD")]
        EPUD = 6,
        [EnumMember(Value = "F_PUD")]
        FPUD = 7,
        [EnumMember(Value = "T_PUD")]
        TPUD = 8,
        [EnumMember(Value = "III PUD")]
        IIIPUD = 9,
        [EnumMember(Value = "P_LimitedReviewNew")]
        PLimitedReviewNew = 10,
        [EnumMember(Value = "Q_LimitedReviewEst")]
        QLimitedReviewEst = 11,
        [EnumMember(Value = "R_ExpeditedNew")]
        RExpeditedNew = 12,
        [EnumMember(Value = "S_ExpeditedEst")]
        SExpeditedEst = 13,
        [EnumMember(Value = "T_FannieMaeReview")]
        TFannieMaeReview = 14,
        [EnumMember(Value = "U_FHAapproved")]
        UFHAapproved = 15,
        [EnumMember(Value = "V_RefiPlus")]
        VRefiPlus = 16,
        DetachedProject = 17,
        [EnumMember(Value = "2To4UnitProject")]
        n2To4UnitProject = 18,
        ReciprocalReview = 19,
        [EnumMember(Value = "Approved FHA/VA Condominium Project Or Spot Loan")]
        ApprovedFHAVACondominiumProjectOrSpotLoan = 20,
        [EnumMember(Value = "G_NotInAProjectOrDevelopment")]
        GNotInAProjectOrDevelopment = 21
    }
}