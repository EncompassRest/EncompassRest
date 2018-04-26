using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GseTitleMannerHeldDescription
    /// </summary>
    public enum GseTitleMannerHeldDescription
    {
        /// <summary>
        /// Community property
        /// </summary>
        [EnumMember(Value = "Community property")]
        CommunityProperty = 0,
        /// <summary>
        /// Joint tenants
        /// </summary>
        [EnumMember(Value = "Joint tenants")]
        JointTenants = 1,
        /// <summary>
        /// Single man
        /// </summary>
        [EnumMember(Value = "Single man")]
        SingleMan = 2,
        /// <summary>
        /// Single woman
        /// </summary>
        [EnumMember(Value = "Single woman")]
        SingleWoman = 3,
        /// <summary>
        /// Married man
        /// </summary>
        [EnumMember(Value = "Married man")]
        MarriedMan = 4,
        /// <summary>
        /// Married woman
        /// </summary>
        [EnumMember(Value = "Married woman")]
        MarriedWoman = 5,
        /// <summary>
        /// Tenants in common
        /// </summary>
        [EnumMember(Value = "Tenants in common")]
        TenantsInCommon = 6,
        /// <summary>
        /// Tenancy by entirety
        /// </summary>
        [EnumMember(Value = "Tenancy by entirety")]
        TenancyByEntirety = 7,
        /// <summary>
        /// To be decided in escrow
        /// </summary>
        [EnumMember(Value = "To be decided in escrow")]
        ToBeDecidedInEscrow = 8,
        /// <summary>
        /// Unmarried man
        /// </summary>
        [EnumMember(Value = "Unmarried man")]
        UnmarriedMan = 9,
        /// <summary>
        /// Unmarried woman
        /// </summary>
        [EnumMember(Value = "Unmarried woman")]
        UnmarriedWoman = 10,
        /// <summary>
        /// Spouses Married to Each Other
        /// </summary>
        [EnumMember(Value = "Spouses Married to Each Other")]
        SpousesMarriedToEachOther = 11,
        /// <summary>
        /// Other
        /// </summary>
        Other = 12
    }
}