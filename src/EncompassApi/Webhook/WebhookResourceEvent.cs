using System.Runtime.Serialization;

namespace EncompassApi.Webhook
{
    /// <summary>
    /// WebhookResourceEvent
    /// </summary>
    public enum WebhookResourceEvent
    {
        /// <summary>
        /// create
        /// </summary>
        [EnumMember(Value = "create")]
        Create = 0,
        /// <summary>
        /// update
        /// </summary>
        [EnumMember(Value = "update")]
        Update = 1,
        /// <summary>
        /// submit
        /// </summary>
        [EnumMember(Value = "submit")]
        Submit = 2,
        /// <summary>
        /// change
        /// </summary>
        [EnumMember(Value = "change")]
        Change = 3,
        /// <summary>
        /// move
        /// </summary>
        [EnumMember(Value = "move")]
        Move = 4,
        /// <summary>
        /// delete
        /// </summary>
        [EnumMember(Value = "delete")]
        Delete = 5,
        /// <summary>
        /// document
        /// </summary>
        [EnumMember(Value = "document")]
        Document = 6,
        /// <summary>
        /// attachment
        /// </summary>
        [EnumMember(Value = "attachment")]
        Attachment = 7,
        /// <summary>
        /// condition
        /// </summary>
        [EnumMember(Value = "condition")]
        Condition = 8,
        /// <summary>
        /// reportingdbupdate
        /// </summary>
        [EnumMember(Value = "reportingdbupdate")]
        ReportingDBUpdate = 9,
        /// <summary>
        /// milestone
        /// </summary>
        [EnumMember(Value = "milestone")]
        Milestone = 10,
        /// <summary>
        /// publish
        /// </summary>
        [EnumMember(Value = "publish")]
        Publish = 11,
        /// <summary>
        /// loanassignmentcomplete
        /// </summary>
        [EnumMember(Value = "loanassignmentcomplete")]
        LoanAssignmentComplete = 12,
        /// <summary>
        /// lock
        /// </summary>
        [EnumMember(Value = "lock")]
        Lock = 13,
        /// <summary>
        /// unlock
        /// </summary>
        [EnumMember(Value = "unlock")]
        Unlock = 14,
        /// <summary>
        /// placed
        /// </summary>
        [EnumMember(Value = "placed")]
        Placed = 15,
        /// <summary>
        /// acknowledged
        /// </summary>
        [EnumMember(Value = "acknowledged")]
        Acknowledged = 16,
        /// <summary>
        /// fulfilled
        /// </summary>
        [EnumMember(Value = "fulfilled")]
        Fulfilled = 17,
        /// <summary>
        /// systemfailure
        /// </summary>
        [EnumMember(Value = "systemfailure")]
        SystemFailure = 18,
        /// <summary>
        /// processfailure
        /// </summary>
        [EnumMember(Value = "processfailure")]
        ProcessFailure = 19,
        /// <summary>
        /// openingauditcompleted
        /// </summary>
        [EnumMember(Value = "openingauditcompleted")]
        OpeningAuditCompleted = 20,
        /// <summary>
        /// openingauditfailed
        /// </summary>
        [EnumMember(Value = "openingauditfailed")]
        OpeningAuditFailed = 21,
        /// <summary>
        /// openingordercompleted
        /// </summary>
        [EnumMember(Value = "openingordercompleted")]
        OpeningOrderCompleted = 22,
        /// <summary>
        /// openingorderfailed
        /// </summary>
        [EnumMember(Value = "openingorderfailed")]
        OpeningOrderFailed = 23,
        /// <summary>
        /// openingdeliverycompleted
        /// </summary>
        [EnumMember(Value = "openingdeliverycompleted")]
        OpeningDeliveryCompleted = 24,
        /// <summary>
        /// openingdeliveryfailed
        /// </summary>
        [EnumMember(Value = "openingdeliveryfailed")]
        OpeningDeliveryFailed = 25,
        /// <summary>
        /// closingauditcompleted
        /// </summary>
        [EnumMember(Value = "closingauditcompleted")]
        ClosingAuditCompleted = 26,
        /// <summary>
        /// closingauditfailed
        /// </summary>
        [EnumMember(Value = "closingauditfailed")]
        ClosingAuditFailed = 27,
        /// <summary>
        /// closingordercompleted
        /// </summary>
        [EnumMember(Value = "closingordercompleted")]
        ClosingOrderCompleted = 28,
        /// <summary>
        /// closingorderfailed
        /// </summary>
        [EnumMember(Value = "closingorderfailed")]
        ClosingOrderFailed = 29,
        /// <summary>
        /// closingdeliverycompleted
        /// </summary>
        [EnumMember(Value = "closingdeliverycompleted")]
        ClosingDeliveryCompleted = 30,
        /// <summary>
        /// closingdeliveryfailed
        /// </summary>
        [EnumMember(Value = "closingdeliveryfailed")]
        ClosingDeliveryFailed = 31,
        /// <summary>
        /// closingpackagecompleted
        /// </summary>
        [EnumMember(Value = "closingpackagecompleted")]
        ClosingPackageCompleted = 32,
        /// <summary>
        /// closingpackagefailed
        /// </summary>
        [EnumMember(Value = "closingpackagefailed")]
        ClosingPackageFailed = 33,
        /// <summary>
        /// formscompleted
        /// </summary>
        [EnumMember(Value = "formscompleted")]
        FormsCompleted = 34,
        /// <summary>
        /// formsfailed
        /// </summary>
        [EnumMember(Value = "formsfailed")]
        FormsFailed = 35,
        /// <summary>
        /// formsdeliverycompleted
        /// </summary>
        [EnumMember(Value = "formsdeliverycompleted")]
        FormsDeliveryCompleted = 36,
        /// <summary>
        /// formsdeliveryfailed
        /// </summary>
        [EnumMember(Value = "formsdeliveryfailed")]
        FormsDeliveryFailed = 37
    }
}