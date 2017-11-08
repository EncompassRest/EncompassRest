using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BusinessOrCommercialPurpose
    {
        [EnumMember(Value = "Primarily for a business or commercial purpose")]
        PrimarilyForABusinessOrCommercialPurpose = 0,
        [EnumMember(Value = "Not primarily for a business or commercial purpose")]
        NotPrimarilyForABusinessOrCommercialPurpose = 1
    }
}