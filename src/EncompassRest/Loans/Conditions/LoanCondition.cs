using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Conditions
{
    public abstract class LoanCondition : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _templateId;
        public string TemplateId { get => _templateId; set => _templateId = value; }
        private DirtyValue<StringEnumValue<ConditionType>> _conditionType;
        public StringEnumValue<ConditionType> ConditionType { get => _conditionType; set => _conditionType = value; }
        private DirtyValue<bool?> _isRemoved;
        public bool? IsRemoved { get => _isRemoved; set => _isRemoved = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private EntityReference _application;
        public EntityReference Application { get => _application ?? (_application = new EntityReference()); set => _application = value; }
        private DirtyValue<bool?> _forAllApplications;
        public bool? ForAllApplications { get => _forAllApplications; set => _forAllApplications = value; }
        private DirtyValue<StringEnumValue<ConditionSource>> _source;
        public StringEnumValue<ConditionSource> Source { get => _source; set => _source = value; }
        private DirtyValue<DateTime?> _expectedDate;
        public DateTime? ExpectedDate { get => _expectedDate; set => _expectedDate = value; }
        private DirtyValue<StringEnumValue<ConditionStatus>> _status;
        public StringEnumValue<ConditionStatus> Status { get => _status; set => _status = value; }
        private DirtyValue<DateTime?> _statusDate;
        public DateTime? StatusDate { get => _statusDate; set => _statusDate = value; }
        private DirtyValue<int?> _daysToReceive;
        public int? DaysToReceive { get => _daysToReceive; set => _daysToReceive = value; }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get => _requestedFrom; set => _requestedFrom = value; }
        private DirtyValue<DateTime?> _createdDate;
        public DateTime? CreatedDate { get => _createdDate; set => _createdDate = value; }
        private EntityReference _createdBy;
        public EntityReference CreatedBy { get => _createdBy ?? (_createdBy = new EntityReference()); set => _createdBy = value; }
        private DirtyValue<bool?> _isRequested;
        public bool? IsRequested { get => _isRequested; set => _isRequested = value; }
        private DirtyValue<DateTime?> _requestedDate;
        public DateTime? RequestedDate { get => _requestedDate; set => _requestedDate = value; }
        private EntityReference _requestedBy;
        public EntityReference RequestedBy { get => _requestedBy ?? (_requestedBy = new EntityReference()); set => _requestedBy = value; }
        private DirtyValue<bool?> _isRerequested;
        public bool? IsRerequested { get => _isRerequested; set => _isRerequested = value; }
        private DirtyValue<DateTime?> _rerequestedDate;
        public DateTime? RerequestedDate { get => _rerequestedDate; set => _rerequestedDate = value; }
        private EntityReference _rerequestedBy;
        public EntityReference RerequestedBy { get => _rerequestedBy ?? (_rerequestedBy = new EntityReference()); set => _rerequestedBy = value; }
        private DirtyValue<bool?> _isReceived;
        public bool? IsReceived { get => _isReceived; set => _isReceived = value; }
        private DirtyValue<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private EntityReference _receivedBy;
        public EntityReference ReceivedBy { get => _receivedBy ?? (_receivedBy = new EntityReference()); set => _receivedBy = value; }
        private DirtyValue<bool?> _isAddedToConditionSet;
        public bool? IsAddedToConditionSet { get => _isAddedToConditionSet; set => _isAddedToConditionSet = value; }
        private DirtyList<ConditionComment> _comments;
        public IList<ConditionComment> Comments { get => _comments ?? (_comments = new DirtyList<ConditionComment>()); set => _comments = new DirtyList<ConditionComment>(value); }
        private DirtyList<EntityReference> _documents;
        public IList<EntityReference> Documents { get => _documents ?? (_documents = new DirtyList<EntityReference>()); set => _documents = new DirtyList<EntityReference>(value); }

        internal LoanCondition()
        {
        }

        internal override bool DirtyInternal
        {
            get => _id.Dirty
                || _templateId.Dirty
                || _conditionType.Dirty
                || _isRemoved.Dirty
                || _title.Dirty
                || _description.Dirty
                || _forAllApplications.Dirty
                || _source.Dirty
                || _expectedDate.Dirty
                || _status.Dirty
                || _statusDate.Dirty
                || _daysToReceive.Dirty
                || _requestedFrom.Dirty
                || _createdDate.Dirty
                || _isRequested.Dirty
                || _requestedDate.Dirty
                || _isRerequested.Dirty
                || _rerequestedDate.Dirty
                || _isReceived.Dirty
                || _receivedDate.Dirty
                || _isAddedToConditionSet.Dirty
                || _application?.Dirty == true
                || _createdBy?.Dirty == true
                || _requestedBy?.Dirty == true
                || _rerequestedBy?.Dirty == true
                || _receivedBy?.Dirty == true
                || _comments?.Dirty == true
                || _documents?.Dirty == true;
            set
            {
                _id.Dirty = value;
                _templateId.Dirty = value;
                _conditionType.Dirty = value;
                _isRemoved.Dirty = value;
                _title.Dirty = value;
                _description.Dirty = value;
                _forAllApplications.Dirty = value;
                _source.Dirty = value;
                _expectedDate.Dirty = value;
                _status.Dirty = value;
                _statusDate.Dirty = value;
                _daysToReceive.Dirty = value;
                _requestedFrom.Dirty = value;
                _createdDate.Dirty = value;
                _isRequested.Dirty = value;
                _requestedDate.Dirty = value;
                _isRerequested.Dirty = value;
                _rerequestedDate.Dirty = value;
                _isReceived.Dirty = value;
                _receivedDate.Dirty = value;
                _isAddedToConditionSet.Dirty = value;
                if (_application != null) _application.Dirty = value;
                if (_createdBy != null) _createdBy.Dirty = value;
                if (_requestedBy != null) _requestedBy.Dirty = value;
                if (_rerequestedBy != null) _rerequestedBy.Dirty = value;
                if (_receivedBy != null) _receivedBy.Dirty = value;
                if (_comments != null) _comments.Dirty = value;
                if (_documents != null) _documents.Dirty = value;
            }
        }
    }
}