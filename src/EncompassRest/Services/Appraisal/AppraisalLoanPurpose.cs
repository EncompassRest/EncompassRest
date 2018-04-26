using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Appraisal
{
    public enum AppraisalLoanPurpose
    {
        Construction = 0,
        [EnumMember(Value = "Construction Permanent")]
        ConstructionPermanent = 1,
        HELOC = 2,
        [EnumMember(Value = "OREO/SAD")]
        OREO_SAD = 3,
        Purchase = 4,
        Refinance = 5,
        Renewal = 6,
        [EnumMember(Value = "Second Mortgage")]
        SecondMortgage = 7,
        Other = 8
    }
}