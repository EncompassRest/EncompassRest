using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Conditions
{
    public abstract class LoanCondition : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private DirtyValue<string> _templateId;
        private DirtyValue<StringEnumValue<ConditionType>> _conditionType;
        private DirtyValue<bool?> _isRemoved;
        private DirtyValue<string> _title;
        private DirtyValue<string> _description;
        private EntityReference _application;
        private DirtyValue<bool?> _forAllApplications;
        private DirtyValue<StringEnumValue<ConditionSource>> _source;
        private DirtyValue<DateTime?> _expectedDate;
        private DirtyValue<StringEnumValue<ConditionStatus>> _status;
        private DirtyValue<DateTime?> _statusDate;
        private DirtyValue<int?> _daysToReceive;
        private DirtyValue<string> _requestedFrom;
        private DirtyValue<DateTime?> _createdDate;
        private EntityReference _createdBy;
        private DirtyValue<bool?> _isRequested;
        private DirtyValue<DateTime?> _requestedDate;
        private EntityReference _requestedBy;
        private DirtyValue<bool?> _isRerequested;
        private DirtyValue<DateTime?> _rerequestedDate;
        private EntityReference _rerequestedBy;
        private DirtyValue<bool?> _isReceived;
        private DirtyValue<DateTime?> _receivedDate;
        private EntityReference _receivedBy;
        private DirtyValue<bool?> _isAddedToConditionSet;
        private DirtyList<ConditionComment> _comments;
        private DirtyList<EntityReference> _documents;

        public string Id { get => _id; set => SetField(ref _id, value); }

        public string TemplateId { get => _templateId; set => SetField(ref _templateId, value); }

        public StringEnumValue<ConditionType> ConditionType { get => _conditionType; set => SetField(ref _conditionType, value); }

        public bool? IsRemoved { get => _isRemoved; set => SetField(ref _isRemoved, value); }

        public string Title { get => _title; set => SetField(ref _title, value); }

        public string Description { get => _description; set => SetField(ref _description, value); }

        public EntityReference Application { get => GetField(ref _application); set => SetField(ref _application, value); }

        public bool? ForAllApplications { get => _forAllApplications; set => SetField(ref _forAllApplications, value); }

        public StringEnumValue<ConditionSource> Source { get => _source; set => SetField(ref _source, value); }

        public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

        public StringEnumValue<ConditionStatus> Status { get => _status; set => SetField(ref _status, value); }

        public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

        public int? DaysToReceive { get => _daysToReceive; set => SetField(ref _daysToReceive, value); }

        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

        public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }

        public bool? IsRequested { get => _isRequested; set => SetField(ref _isRequested, value); }

        public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

        public EntityReference RequestedBy { get => GetField(ref _requestedBy); set => SetField(ref _requestedBy, value); }

        public bool? IsRerequested { get => _isRerequested; set => SetField(ref _isRerequested, value); }

        public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }

        public EntityReference RerequestedBy { get => GetField(ref _rerequestedBy); set => SetField(ref _rerequestedBy, value); }

        public bool? IsReceived { get => _isReceived; set => SetField(ref _isReceived, value); }

        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

        public EntityReference ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }

        public bool? IsAddedToConditionSet { get => _isAddedToConditionSet; set => SetField(ref _isAddedToConditionSet, value); }

        public IList<ConditionComment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }

        public IList<EntityReference> Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

        internal LoanCondition()
        {
        }
    }
}