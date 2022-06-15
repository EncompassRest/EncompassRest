using System.Runtime.Serialization;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookResourceType
    /// </summary>
    public enum WebhookResourceType
    {
        /// <summary>
        /// loan
        /// </summary>
        [EnumMember(Value = "loan")]
        Loan = 0,
        /// <summary>
        /// Transaction
        /// </summary>
        Transaction = 1,
        /// <summary>
        /// TaskGroup
        /// </summary>
        TaskGroup = 2,
        /// <summary>
        /// EnhancedConditionTemplate
        /// </summary>
        EnhancedConditionTemplate = 3,
        /// <summary>
        /// Task
        /// </summary>
        Task = 4,
        /// <summary>
        /// EnhancedConditionType
        /// </summary>
        EnhancedConditionType = 5,
        /// <summary>
        /// SubTask
        /// </summary>
        SubTask = 6,
        /// <summary>
        /// ExternalOrganization
        /// </summary>
        ExternalOrganization = 7,
        /// <summary>
        /// Trade
        /// </summary>
        Trade = 8,
        /// <summary>
        /// ServiceOrder
        /// </summary>
        ServiceOrder = 9,
        /// <summary>
        /// DocumentOrder
        /// </summary>
        DocumentOrder = 10,
        /// <summary>
        /// EFolder
        /// </summary>
        EFolder = 11,
        /// <summary>
        /// DataSource
        /// </summary>
        DataSource = 12,
        /// <summary>
        /// Document
        /// </summary>
        Document = 13,
        /// <summary>
        /// AnalyzerResult
        /// </summary>
        AnalyzerResult = 14,
        /// <summary>
        /// ReceivedMailItem
        /// </summary>
        ReceivedMailItem = 15,
        /// <summary>
        /// AnalyzerDocumentValidationResult
        /// </summary>
        AnalyzerDocumentValidationResult = 16
    }
}