using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Conditions
{
    public abstract class LoanCondition : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _templateId;
        public string TemplateId { get => _templateId; set => SetField(ref _templateId, value); }
        private DirtyValue<StringEnumValue<ConditionType>> _conditionType;
        public StringEnumValue<ConditionType> ConditionType { get => _conditionType; set => SetField(ref _conditionType, value); }
        private DirtyValue<bool?> _isRemoved;
        public bool? IsRemoved { get => _isRemoved; set => SetField(ref _isRemoved, value); }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => SetField(ref _description, value); }
        private EntityReference _application;
        public EntityReference Application { get => GetField(ref _application); set => SetField(ref _application, value); }
        private DirtyValue<bool?> _forAllApplications;
        public bool? ForAllApplications { get => _forAllApplications; set => SetField(ref _forAllApplications, value); }
        private DirtyValue<StringEnumValue<ConditionSource>> _source;
        public StringEnumValue<ConditionSource> Source { get => _source; set => SetField(ref _source, value); }
        private DirtyValue<DateTime?> _expectedDate;
        public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }
        private DirtyValue<StringEnumValue<ConditionStatus>> _status;
        public StringEnumValue<ConditionStatus> Status { get => _status; set => SetField(ref _status, value); }
        private DirtyValue<DateTime?> _statusDate;
        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }
        private DirtyValue<int?> _daysToReceive;
        public int? DaysToReceive { get => _daysToReceive; set => SetField(ref _daysToReceive, value); }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }
        private DirtyValue<DateTime?> _createdDate;
        public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }
        private EntityReference _createdBy;
        public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }
        private DirtyValue<bool?> _isRequested;
        public bool? IsRequested { get => _isRequested; set => SetField(ref _isRequested, value); }
        private DirtyValue<DateTime?> _requestedDate;
        public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }
        private EntityReference _requestedBy;
        public EntityReference RequestedBy { get => GetField(ref _requestedBy); set => SetField(ref _requestedBy, value); }
        private DirtyValue<bool?> _isRerequested;
        public bool? IsRerequested { get => _isRerequested; set => SetField(ref _isRerequested, value); }
        private DirtyValue<DateTime?> _rerequestedDate;
        public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }
        private EntityReference _rerequestedBy;
        public EntityReference RerequestedBy { get => GetField(ref _rerequestedBy); set => SetField(ref _rerequestedBy, value); }
        private DirtyValue<bool?> _isReceived;
        public bool? IsReceived { get => _isReceived; set => SetField(ref _isReceived, value); }
        private DirtyValue<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }
        private EntityReference _receivedBy;
        public EntityReference ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }
        private DirtyValue<bool?> _isAddedToConditionSet;
        public bool? IsAddedToConditionSet { get => _isAddedToConditionSet; set => SetField(ref _isAddedToConditionSet, value); }
        private DirtyList<ConditionComment> _comments;
        public IList<ConditionComment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }
        private DirtyList<EntityReference> _documents;
        public IList<EntityReference> Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

        internal LoanCondition()
        {
        }
    }
}