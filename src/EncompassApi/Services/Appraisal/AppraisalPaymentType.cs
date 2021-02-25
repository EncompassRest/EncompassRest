using System.Runtime.Serialization;

namespace EncompassApi.Services.Appraisal
{
    /// <summary>
    /// AppraisalPaymentType
    /// </summary>
    public enum AppraisalPaymentType
    {
        /// <summary>
        /// Check
        /// </summary>
        Check = 0,
        /// <summary>
        /// C.O.D.
        /// </summary>
        [EnumMember(Value = "C.O.D.")]
        COD = 1,
        /// <summary>
        /// Credit Card
        /// </summary>
        [EnumMember(Value = "Credit Card")]
        CreditCard = 2,
        /// <summary>
        /// Money order
        /// </summary>
        [EnumMember(Value = "Money order")]
        MoneyOrder = 3,
        /// <summary>
        /// Net 30
        /// </summary>
        [EnumMember(Value = "Net 30")]
        Net30 = 4,
        /// <summary>
        /// PayPal
        /// </summary>
        PayPal = 5,
        /// <summary>
        /// Invoice
        /// </summary>
        Invoice = 6,
        /// <summary>
        /// Deferred CC
        /// </summary>
        [EnumMember(Value = "Deferred CC")]
        DeferredCC = 7
    }
}