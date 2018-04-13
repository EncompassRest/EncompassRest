using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Flood
{
    public enum FloodProductName
    {
        [EnumMember(Value = "Basic Determination")]
        BasicDetermination = 25,
        [EnumMember(Value = "Life of Loan Determination")]
        LifeOfLoanDetermination = 26
    }
}