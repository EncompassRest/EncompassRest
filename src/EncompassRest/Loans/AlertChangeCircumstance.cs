using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AlertChangeCircumstance
    /// </summary>
    public sealed partial class AlertChangeCircumstance : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _alertTriggerFieldID;
        private DirtyValue<string> _altId;
        private DirtyValue<string> _changedCircumstanceAlertBaseline;
        private DirtyValue<decimal?> _changedCircumstanceAlertDisclosedAmount;
        private DirtyValue<string> _changedCircumstanceAlertFeeDescription;
        private DirtyValue<decimal?> _changedCircumstanceAlertInitialAmount;
        private DirtyValue<decimal?> _changedCircumstanceAlertItemizationAmount;
        private DirtyValue<decimal?> _changedCircumstanceAlertVarianceAmount;
        private DirtyValue<string> _changedCircumstanceCategory;
        private DirtyValue<string> _changedCircumstanceComments;
        private DirtyValue<DateTime?> _changedCircumstanceDate;
        private DirtyValue<string> _changedCircumstanceDescription;
        private DirtyValue<string> _changedCircumstanceReason;
        private DirtyValue<string> _changedCircumstanceReasonOther;
        private DirtyValue<string> _id;
        private DirtyValue<DateTime?> _revisedDueDate;

        /// <summary>
        /// AlertChangeCircumstance AlertTriggerFieldID
        /// </summary>
        public string AlertTriggerFieldID { get => _alertTriggerFieldID; set => SetField(ref _alertTriggerFieldID, value); }

        /// <summary>
        /// AlertChangeCircumstance AltId
        /// </summary>
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceAlertBaseline
        /// </summary>
        public string ChangedCircumstanceAlertBaseline { get => _changedCircumstanceAlertBaseline; set => SetField(ref _changedCircumstanceAlertBaseline, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceAlertDisclosedAmount
        /// </summary>
        public decimal? ChangedCircumstanceAlertDisclosedAmount { get => _changedCircumstanceAlertDisclosedAmount; set => SetField(ref _changedCircumstanceAlertDisclosedAmount, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceAlertFeeDescription
        /// </summary>
        public string ChangedCircumstanceAlertFeeDescription { get => _changedCircumstanceAlertFeeDescription; set => SetField(ref _changedCircumstanceAlertFeeDescription, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceAlertInitialAmount
        /// </summary>
        public decimal? ChangedCircumstanceAlertInitialAmount { get => _changedCircumstanceAlertInitialAmount; set => SetField(ref _changedCircumstanceAlertInitialAmount, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceAlertItemizationAmount
        /// </summary>
        public decimal? ChangedCircumstanceAlertItemizationAmount { get => _changedCircumstanceAlertItemizationAmount; set => SetField(ref _changedCircumstanceAlertItemizationAmount, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceAlertVarianceAmount
        /// </summary>
        public decimal? ChangedCircumstanceAlertVarianceAmount { get => _changedCircumstanceAlertVarianceAmount; set => SetField(ref _changedCircumstanceAlertVarianceAmount, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceCategory
        /// </summary>
        public string ChangedCircumstanceCategory { get => _changedCircumstanceCategory; set => SetField(ref _changedCircumstanceCategory, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceComments
        /// </summary>
        public string ChangedCircumstanceComments { get => _changedCircumstanceComments; set => SetField(ref _changedCircumstanceComments, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceDate
        /// </summary>
        public DateTime? ChangedCircumstanceDate { get => _changedCircumstanceDate; set => SetField(ref _changedCircumstanceDate, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceDescription
        /// </summary>
        public string ChangedCircumstanceDescription { get => _changedCircumstanceDescription; set => SetField(ref _changedCircumstanceDescription, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceReason
        /// </summary>
        public string ChangedCircumstanceReason { get => _changedCircumstanceReason; set => SetField(ref _changedCircumstanceReason, value); }

        /// <summary>
        /// AlertChangeCircumstance ChangedCircumstanceReasonOther
        /// </summary>
        public string ChangedCircumstanceReasonOther { get => _changedCircumstanceReasonOther; set => SetField(ref _changedCircumstanceReasonOther, value); }

        /// <summary>
        /// AlertChangeCircumstance Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// AlertChangeCircumstance RevisedDueDate
        /// </summary>
        public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }
    }
}