using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HmdaLoanType
    {
        Conventional = 0,
        FHA = 1,
        VA = 2,
        [EnumMember(Value = "USDA-RHS or FSA")]
        USDARHSOrFSA = 3
    }
}