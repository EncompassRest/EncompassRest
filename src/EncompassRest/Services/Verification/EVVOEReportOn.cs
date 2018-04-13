using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Verification
{
    public enum EVVOEReportOn
    {
        Borrower = 0,
        [EnumMember(Value = "Co-Borrower")]
        CoBorrower = 1
    }
}