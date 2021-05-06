using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.Flood
{
    /// <summary>
    /// FloodRequestType
    /// </summary>
    public enum FloodRequestType
    {
        /// <summary>
        /// newRequest: A request for a new Flood certification for the subject property
        /// </summary>
        [EnumMember(Value = "newRequest")]
        NewRequest = 0,
        /// <summary>
        /// retrieve: A request to retrieve a previously issued Flood certification for the subject property
        /// </summary>
        [EnumMember(Value = "retrieve")]
        Retrieve = 1,
        /// <summary>
        /// cancel: Cancel a previously issued Flood certification for the subject property
        /// </summary>
        [EnumMember(Value = "cancel")]
        Cancel = 2,
        /// <summary>
        /// upgrade: Upgrade a previously issued Basic Flood certification to a Life of Loan Flood Certification
        /// </summary>
        [EnumMember(Value = "upgrade")]
        Upgrade = 3,
        /// <summary>
        /// transfer: Transfer the Flood certification to another servicer
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer = 4,
        /// <summary>
        /// change: Make changes to a previously issued Basic Flood certificate
        /// </summary>
        [EnumMember(Value = "change")]
        Change = 5,
        /// <summary>
        /// 2ndMortgage: Reissue a Flood certificate for a 2nd mortgage on the subject property
        /// </summary>
        [EnumMember(Value = "2ndMortgage")]
        SecondMortgage = 6,
        /// <summary>
        /// refinance: Reissue a Flood certificate when refinancing an existing mortgage on the subject property
        /// </summary>
        [EnumMember(Value = "refinance")]
        Refinance = 7,
        /// <summary>
        /// retrieveReport: A request to retrieve a previously issued Flood certification for the subject property
        /// </summary>
        [EnumMember(Value = "retrieveReport")]
        RetrieveReport = 8,
        /// <summary>
        /// cancelRequest: Cancel a previously issued Flood certification for the subject property
        /// </summary>
        [EnumMember(Value = "cancelRequest")]
        CancelRequest = 9,
        /// <summary>
        /// requestUpdate: Update a previously issued Flood certification
        /// </summary>
        [EnumMember(Value = "requestUpdate")]
        RequestUpdate = 10
    }
}