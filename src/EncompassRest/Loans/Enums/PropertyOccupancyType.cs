using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PropertyOccupancyType
    {
        [EnumMember(Value = "Occupied by owner")]
        OccupiedByOwner = 0,
        [EnumMember(Value = "Never occupied")]
        NeverOccupied = 1,
        Vacant = 2,
        [EnumMember(Value = "Occupied by tenant")]
        OccupiedByTenant = 3
    }
}