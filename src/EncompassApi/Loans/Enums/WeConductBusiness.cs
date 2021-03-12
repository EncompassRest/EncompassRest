using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// WeConductBusiness
    /// </summary>
    public enum WeConductBusiness
    {
        /// <summary>
        /// An Individual
        /// </summary>
        [EnumMember(Value = "An Individual")]
        AnIndividual = 0,
        /// <summary>
        /// A Corporation
        /// </summary>
        [EnumMember(Value = "A Corporation")]
        ACorporation = 1,
        /// <summary>
        /// A Partnership
        /// </summary>
        [EnumMember(Value = "A Partnership")]
        APartnership = 2,
        /// <summary>
        /// An Association
        /// </summary>
        [EnumMember(Value = "An Association")]
        AnAssociation = 3,
        /// <summary>
        /// LLC
        /// </summary>
        LLC = 4,
        /// <summary>
        /// Other
        /// </summary>
        Other = 5
    }
}