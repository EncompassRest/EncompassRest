using System.Runtime.Serialization;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// OrganizationView
    /// </summary>
    public enum OrganizationView
    {
        /// <summary>
        /// summary
        /// </summary>
        [EnumMember(Value = "summary")]
        Summary = 0,
        /// <summary>
        /// entity
        /// </summary>
        [EnumMember(Value = "entity")]
        Entity = 1,
        /// <summary>
        /// hierarchy
        /// </summary>
        [EnumMember(Value = "hierarchy")]
        Hierarchy = 2
    }
}