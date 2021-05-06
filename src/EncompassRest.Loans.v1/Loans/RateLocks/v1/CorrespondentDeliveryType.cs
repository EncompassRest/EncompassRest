using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
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