using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PropertyDesignation
    {
        ExistingOrUsedHome = 0,
        ProposedConstruction = 1,
        [EnumMember(Value = "NewExisting-NeverOccupied")]
        NewExistingNeverOccupied = 2,
        EnergyImprovements = 3
    }
}