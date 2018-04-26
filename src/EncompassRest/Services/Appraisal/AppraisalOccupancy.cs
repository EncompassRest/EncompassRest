using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Appraisal
{
    public enum AppraisalOccupancy
    {
        [EnumMember(Value = "New Construction")]
        NewConstruction = 0,
        [EnumMember(Value = "Not Applicable")]
        NotApplicable = 1,
        Owner = 2,
        [EnumMember(Value = "Owner's Second Home")]
        OwnersSecondHome = 3,
        Tenant = 4,
        Vacant = 5
    }
}