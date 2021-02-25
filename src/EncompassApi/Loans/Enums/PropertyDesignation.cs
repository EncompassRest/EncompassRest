using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PropertyDesignation
    /// </summary>
    public enum PropertyDesignation
    {
        /// <summary>
        /// Existing or Used Home,Condo,M/H
        /// </summary>
        [Description("Existing or Used Home,Condo,M/H")]
        ExistingOrUsedHome = 0,
        /// <summary>
        /// Proposed Construction
        /// </summary>
        [Description("Proposed Construction")]
        ProposedConstruction = 1,
        /// <summary>
        /// New Existing-Never Occupied
        /// </summary>
        [Description("New Existing-Never Occupied")]
        [EnumMember(Value = "NewExisting-NeverOccupied")]
        NewExistingNeverOccupied = 2,
        /// <summary>
        /// Energy Improvements
        /// </summary>
        [Description("Energy Improvements")]
        EnergyImprovements = 3
    }
}