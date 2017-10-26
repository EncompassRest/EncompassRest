using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanProcedure
    {
        Automatic = 0,
        [EnumMember(Value = "Auto-IRRRL")]
        AutoIRRRL = 1,
        VAPriorApproval = 2
    }
}