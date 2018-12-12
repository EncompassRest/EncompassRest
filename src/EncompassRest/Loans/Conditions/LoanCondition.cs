using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// LoanCondition
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ForAllApplications) + "," + nameof(Application))]
    public abstract class LoanCondition : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private DirtyValue<string> _templateId;
        private DirtyValue<StringEnumValue<ConditionType>> _conditionType;
        private DirtyValue<bool?> _isRemoved;
        private DirtyValue<string> _title;
        private DirtyValue<string> _description;
        private DirtyValue<EntityReference> _application;
        private DirtyValue<bool?> _forAllApplications;
        private DirtyValue<StringEnumValue<ConditionSource>> _source;
        private DirtyValue<DateTime?> _expectedDate;
        private DirtyValue<StringEnumValue<ConditionStatus>> _status;
        private DirtyValue<DateTime?> _statusDate;
        private DirtyValue<int?> _daysToReceive;
        private DirtyValue<string> _requestedFrom;
        private DirtyValue<DateTime?> _createdDate;
        private DirtyValue<EntityReference> _createdBy;
        private DirtyValue<bool?> _isRequested;
        private DirtyValue<DateTime?> _requestedDate;
        private DirtyValue<EntityReference> _requestedBy;
        private DirtyValue<bool?> _isRerequested;
        private DirtyValue<DateTime?> _rerequestedDate;
        private DirtyValue<EntityReference> _rerequestedBy;
        private DirtyValue<bool?> _isReceived;
        private DirtyValue<DateTime?> _receivedDate;
        private DirtyValue<EntityReference> _receivedBy;
        private DirtyValue<bool?> _isAddedToConditionSet;
        private DirtyList<Comment> _comments;
        private DirtyList<EntityReference> _documents;

        /// <summary>
        /// Unique identifier of a condition.
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// The ID of the template used to create the condition.
        /// </summary>
        public string TemplateId { get => _templateId; set => SetField(ref _templateId, value); }

        /// <summary>
        /// Type of a condition.
        /// </summary>
        public StringEnumValue<ConditionType> ConditionType { get => _conditionType; set => SetField(ref _conditionType, value); }

        /// <summary>
        /// Whether the condition's status is Removed.
        /// </summary>
        public bool? IsRemoved { get => _isRemoved; set => SetField(ref _isRemoved, value); }

        /// <summary>
        /// Title of the document.
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Description of the document.
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Loan application to which to apply the condition. Required if applying condition to a specific application. If you want to apply the condition to all applications of the loan, set <see cref="ForAllApplications"/> to <c>true</c>.
        /// </summary>
        public EntityReference Application { get => _application; set => SetField(ref _application, value); }

        /// <summary>
        /// A value of <c>true</c> indicates the condition will be linked to all applications or only for a specified application. If linked to a specified application, the application ID must be provided.
        /// </summary>
        public bool? ForAllApplications { get => _forAllApplications; set => SetField(ref _forAllApplications, value); }

        /// <summary>
        /// Source of the condition.
        /// </summary>
        public StringEnumValue<ConditionSource> Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// Date and time the condition is waiting to be received by.
        /// </summary>
        public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

        /// <summary>
        /// Indicates the status of the condition.
        /// </summary>
        public StringEnumValue<ConditionStatus> Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// Date and time the condition's status was last changed.
        /// </summary>
        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

        /// <summary>
        /// Number of days for the condition to be received.
        /// </summary>
        public int? DaysToReceive { get => _daysToReceive; set => SetField(ref _daysToReceive, value); }

        /// <summary>
        /// User who requested the condition.
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        /// <summary>
        /// Date and time the condition was created.
        /// </summary>
        public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

        /// <summary>
        /// Information about the Encompass user who created the condition.
        /// </summary>
        public EntityReference CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        /// <summary>
        /// Whether the condition's status is Requested.
        /// </summary>
        public bool? IsRequested { get => _isRequested; set => SetField(ref _isRequested, value); }

        /// <summary>
        /// Date and time the condition was requested.
        /// </summary>
        public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

        /// <summary>
        /// Information about the Encompass user who requested the condition.
        /// </summary>
        public EntityReference RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// Whether the condition's status is Re-requested.
        /// </summary>
        public bool? IsRerequested { get => _isRerequested; set => SetField(ref _isRerequested, value); }

        /// <summary>
        /// Date and time the condition was rerequested.
        /// </summary>
        public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }

        /// <summary>
        /// Information about the Encompass user who re-requested the condition.
        /// </summary>
        public EntityReference RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// Whether the condition's status is Received.
        /// </summary>
        public bool? IsReceived { get => _isReceived; set => SetField(ref _isReceived, value); }

        /// <summary>
        /// Date and time the condition was received.
        /// </summary>
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

        /// <summary>
        /// Information about the Encompass user who received the condition.
        /// </summary>
        public EntityReference ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// Whether the condition belongs to a condition set.
        /// </summary>
        public bool? IsAddedToConditionSet { get => _isAddedToConditionSet; set => SetField(ref _isAddedToConditionSet, value); }

        /// <summary>
        /// Any comments for the condition.
        /// </summary>
        public IList<Comment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }

        /// <summary>
        /// Any supporting documents.
        /// </summary>
        public IList<EntityReference> Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

        internal LoanCondition()
        {
        }
    }
}