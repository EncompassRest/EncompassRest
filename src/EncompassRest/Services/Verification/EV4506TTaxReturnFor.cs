using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Verification
{
    public enum EV4506TTaxReturnFor
    {
        [EnumMember(Value = "borrower")]
        Borrower = 0,
        [EnumMember(Value = "coBorrower")]
        CoBorrower = 1,
        [EnumMember(Value = "joint")]
        Joint = 2
    }
}