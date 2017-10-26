using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BuildingType
    {
        Detached = 0,
        [EnumMember(Value = "Semi-Detached")]
        SemiDetached = 1,
        Row = 2,
        [EnumMember(Value = "Apt Unit")]
        AptUnit = 3
    }
}