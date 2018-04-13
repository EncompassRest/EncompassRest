using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Verification
{
    public enum EVVOEEmployer
    {
        [EnumMember(Value = "Current Employer(s)")]
        Current = 0,
        [EnumMember(Value = "Previous Employer(s)")]
        Previous = 1,
        [EnumMember(Value = "Both (Current & Previous)")]
        CurrentAndPrevious = 2
    }
}