using System.Runtime.Serialization;

namespace EncompassApi.Services.Appraisal
{
    /// <summary>
    /// AppraisalOccupancy
    /// </summary>
    public enum AppraisalOccupancy
    {
        /// <summary>
        /// New Construction
        /// </summary>
        [EnumMember(Value = "New Construction")]
        NewConstruction = 0,
        /// <summary>
        /// Not Applicable
        /// </summary>
        [EnumMember(Value = "Not Applicable")]
        NotApplicable = 1,
        /// <summary>
        /// Owner
        /// </summary>
        Owner = 2,
        /// <summary>
        /// Owner's Second Home
        /// </summary>
        [EnumMember(Value = "Owner's Second Home")]
        OwnersSecondHome = 3,
        /// <summary>
        /// Tenant
        /// </summary>
        Tenant = 4,
        /// <summary>
        /// Vacant
        /// </summary>
        Vacant = 5
    }
}