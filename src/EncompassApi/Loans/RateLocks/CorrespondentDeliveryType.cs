using System.Runtime.Serialization;

namespace EncompassApi.Loans.RateLocks
{
    /// <summary>
    /// DataSyncOption
    /// </summary>
    public enum CorrespondentDeliveryType
    {
        /// <summary>
        /// Individual Mandatory
        /// </summary>
        [EnumMember(Value = "individual mandatory")]
        IndividualMandatory = 0,
        /// <summary>
        /// Individual Best Efforts
        /// </summary>
        [EnumMember(Value = "individual best efforts")]
        IndividualBestEfforts = 1
    }
}