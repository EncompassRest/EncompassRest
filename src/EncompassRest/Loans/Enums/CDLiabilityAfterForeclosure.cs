using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CDLiabilityAfterForeclosure
    {
        [EnumMember(Value = "state law may protect liability for the unpaid balance")]
        StateLawMayProtectLiabilityForTheUnpaidBalance = 0,
        [EnumMember(Value = "state law does not protect liability for the unpaid balance")]
        StateLawDoesNotProtectLiabilityForTheUnpaidBalance = 1
    }
}