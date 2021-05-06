using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.Appraisal
{
    /// <summary>
    /// AppraisalRequestType
    /// </summary>
    public enum AppraisalRequestType
    {
        /// <summary>
        /// feeQuote: to request a rate quote for the appraisal service. The rate quote request itself is free of cost.
        /// </summary>
        [EnumMember(Value = "feeQuote")]
        FeeQuote = 0,
        /// <summary>
        /// newOrder: to request a new appraisal service for the property as listed on the loan.
        /// </summary>
        [EnumMember(Value = "newOrder")]
        NewOrder = 1,
        /// <summary>
        /// checkStatus: to retrieve the status of an existing order.
        /// </summary>
        [EnumMember(Value = "checkStatus")]
        CheckStatus = 2,
        /// <summary>
        /// existingOrder: to update an existing order with new product options.
        /// </summary>
        [EnumMember(Value = "existingOrder")]
        ExistingOrder = 3
    }
}