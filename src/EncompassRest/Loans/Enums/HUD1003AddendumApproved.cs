using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HUD1003AddendumApproved
    {
        Approved = 0,
        [EnumMember(Value = "Modified And Approved")]
        ModifiedAndApproved = 1
    }
}